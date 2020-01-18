using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Security.Permissions;

using ModeData.ModelDomain;
using DevExpress.XtraGrid.Views.Grid;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient;
using System.Diagnostics;
using System.IO;
using DevExpress.XtraReports.UI;
using System.Configuration;
using System.Reflection;
using System.Threading;

/// <summary>
/// https://chartio.com/help/data-sources/granting-table-level-permissions-in-sql-server/
/// </summary>
namespace SaleOnline
{
    public partial class frmOnlineSale : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        SettingServerOnline settingServer;
        List<SaleFoodReport> _liSaleOnline;
        tblPrinterUserSetting _SettingPrinter;
        RptCustomer rptcustomer = new RptCustomer();
        RptKitchen rptkithchen = new RptKitchen();
        RptCancel rpCancel = new RptCancel();
        SqlNotificationInfo stateFactor;

        public frmOnlineSale()
        {
            InitializeComponent();

            ConnectionDB._conectionString = ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString.ToString();
            if (!GetSetting())
            {
                XtraMessageBox.Show("امکان اجرای برنامه وجود نداره ابتدا تنظیمات پرینتر کاربر مدیر را وارد نمایید",
                    "توجه", MessageBoxButtons.OK);
                this.Close();
                return;
            }
            settingServer = ServicesSaleFood.GetSettingServer();
       
        }
        bool GetSetting()
        {
            bool result = false;
            _SettingPrinter = ServicesSaleFood.GetSettingPrinter();
            if (_SettingPrinter == null) return false;
            if (!string.IsNullOrEmpty(_SettingPrinter.PrinterAshpazkhane))
                result = true;
            return result;
        }

        #region SqlTableDependency

        public void GetNewFact()
        {
            string _con = "data source=.;initial catalog=medb;integrated security=True;User ID=San;Password=123456;";
            if (!CanRequestNotifications())
                return;
            var mapper = new ModelToTableMapper<SaleFoodOnline>();
            mapper.AddMapping(c => c.ID, "ID");
            using (var dep = new SqlTableDependency<SaleFoodOnline>(_con, "SaleFoodOnline", "dbo", mapper))
            {
                dep.OnChanged += Changed;
                dep.TraceLevel = TraceLevel.Verbose;
                dep.TraceListener = new TextWriterTraceListener(Console.Out);
                dep.Start();
                dep.Start();
                //dep.Stop();
            }
        }
        public void Changed(object sender, TableDependency.SqlClient.Base.EventArgs.RecordChangedEventArgs<SaleFoodOnline> e)
        {
            var changedEntity = e.Entity;
            MessageBox.Show("DML operation: " + e.ChangeType);
            MessageBox.Show("ID: " + changedEntity.SaleFoodIDFact);
        }

        #endregion

        #region GetData

        //string _conectionString = "data source=.;initial catalog=db;integrated security=True;User ID=test;Password=123456;";

        private bool CanRequestNotifications()
        {
            SqlClientPermission permission = new SqlClientPermission(PermissionState.Unrestricted);
            try
            {
                permission.Demand();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        async void GetFish()
        {
            await Task.Run(() =>
             {
                 GetData();
             });
        }


        private void GetData()
        {
            string sql = @"SELECT [ID],[SaleFoodIDFact],[NumFish],[SaleDate],[SaleTime]
                        ,[SumPriceBase],[SumNet],[SumDiscount],[SumNetPrice]
                        ,[SumPrice],[TypeFactor],[CustomerName],[CustomerTell]
                        ,[CustomerAddress],[PrintState],[StateDelivery],[Description]
                        FROM [dbo].[SaleFoodOnline] WHERE [SaleDate]>= CAST(GETDATE() AS DATE)";
            try
            {

                if (!CanRequestNotifications())
                    return;
                SqlDependency.Stop(ConnectionDB._conectionString);
                SqlDependency.Start(ConnectionDB._conectionString);
                using (SqlConnection cn = new SqlConnection(ConnectionDB._conectionString))
                {
                    using (SqlCommand cmd = cn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql;
                        cmd.Notification = null;
                        //  creates a new dependency for the SqlCommand
                        SqlDependency dep = new SqlDependency(cmd);
                        dep.OnChange += new OnChangeEventHandler(dep_onchange);
                        cn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                if (_liSaleOnline != null)
                                {
                                    if (_liSaleOnline.Count > 0)
                                    {
                                        var salefood = _liSaleOnline.Where(c => c.ID == dr.GetInt64(0)).SingleOrDefault();
                                        if (salefood != null)
                                        {
                                            //_liSaleOnline.RemoveAll(c => c.ID == dr.GetInt64(0));
                                            _liSaleOnline.Remove(salefood);
                                        }
                                    }
                                }

                                SaleFoodReport fact = new SaleFoodReport();
                                fact.ID = dr.GetInt64(0);
                                fact.SaleFoodIDFact = dr.GetInt64(1);
                                fact.NumFish = dr.GetString(2);
                                fact.SaleDate = dr.GetDateTime(3);
                                fact.SaleTime = dr.GetTimeSpan(4);
                                fact.SumPriceBase = dr.GetInt64(5);
                                fact.SumNet = dr.GetInt64(6);
                                fact.SumDiscount = dr.GetInt64(7);
                                fact.SumNetPrice = dr.GetInt64(8);
                                fact.SumPrice = dr.GetInt64(9);
                                fact.TypeFactor = dr.GetString(10);
                                fact.CustomerName = dr.GetString(11);
                                fact.CustomerTell = dr.GetString(12);
                                fact.CustomerAddress = dr.GetString(13);
                                fact.PrintState = dr.GetBoolean(14);
                                fact.StateDelivery = dr.GetInt32(15);
                                fact.Description = dr.GetString(16);
                                AddItem(fact);

                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
            }


        }

        /// <summary>
        /// تایید وضعیت چاپ فیش 
        /// </summary>
        /// <param name="salefood"></param>
        void IsPrintFish(SaleFoodOnline salefood)
        {
            SaleFoodOnline fact = ServicesSaleFood.GetSalefood(salefood.SaleFoodIDFact.Value);
            fact.PrintState = true;
            ServicesSaleFood.UpdateSaleFoodOnline(fact);
        }

        /// <summary>
        /// ثبت آیتم در لیست
        /// </summary>
        /// <param name="salefood">فاکتور</param>
        void AddItem(SaleFoodReport salefood)
        {
            if (_liSaleOnline == null)
                _liSaleOnline = new List<SaleFoodReport>();

            _liSaleOnline.Add(salefood);
            gridControl1.DataSource = _liSaleOnline.OrderByDescending(c => c.ID);

            if (!salefood.PrintState.Value)
            {
                if (stateFactor == SqlNotificationInfo.Update || stateFactor == SqlNotificationInfo.Insert)
                {
                    #region PrintFish
                    switch (salefood.StateDelivery.Value)
                    {
                        case 0:
                            if (PrintKitchen("", salefood))
                                IsPrintFish(salefood);
                            PrintCustomreFish("", salefood);
                            lblCountNew.Caption = "جدید  " + _liSaleOnline.Where(c => c.StateDelivery == 0).ToList().Count;
                            break;
                        case 1:
                            if (PrintKitchen("اصلاحی", salefood))
                                IsPrintFish(salefood);
                            PrintCustomreFish("اصلاحی", salefood);
                            lblCountEdit.Caption = "ویرایش  " + _liSaleOnline.Where(c => c.StateDelivery == 1).ToList().Count;
                            break;
                        case 2:
                            PrintCancel(salefood.NumFish);
                            lblCountCanceled.Caption = "لغوی  " + _liSaleOnline.Where(c => c.StateDelivery == 2).ToList().Count;
                            break;
                        default:
                            break;
                    }
                    #endregion
                }
            }




            grd.BestFitColumns();

        }
        /// <summary>
        /// مانیتور دیتابیس
        /// </summary>
        void dep_onchange(object sender, SqlNotificationEventArgs e)
        {

            stateFactor = e.Info;
            //if (e.Info == SqlNotificationInfo.Insert)
            //    MessageBox.Show("insert");
            //if(e.Info == SqlNotificationInfo.Update)
            //    MessageBox.Show("Update");
            //if (e.Info == SqlNotificationInfo.Delete)
            //    MessageBox.Show("Delete");

            if (this.InvokeRequired)
                this.BeginInvoke(new MethodInvoker(GetData));
            else
                GetData();
            SqlDependency dep = sender as SqlDependency;
            dep.OnChange -= new OnChangeEventHandler(dep_onchange);
        }

        #endregion

        #region Event
        private void frmOnlineSale_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SqlDependency.Stop(ConnectionDB._conectionString);

                Application.ExitThread();
            }
            finally
            {
                SqlDependency.Stop(ConnectionDB._conectionString);
            }
        }
        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SqlDependency.Stop(ConnectionDB._conectionString);
            this.Close();
        }
        private void grd_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                int state = view.GetRowCellValue(e.RowHandle, colStateDelivery).ToInt();
                switch (state)
                {
                    case 0:
                        //e.Appearance.BackColor = Color.GreenYellow;

                        break;

                    case 1:
                        e.Appearance.BackColor = Color.Cyan;
                        e.Appearance.ForeColor = Color.Black;
                        e.HighPriority = true;
                        break;
                    case 2:
                        e.Appearance.BackColor = Color.DeepPink;
                        e.Appearance.ForeColor = Color.Black;
                        e.HighPriority = true;
                        break;
                }
            }




        }
        private void grd_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        #endregion

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                return Image.FromStream(ms, true);//Exception occurs here
            }
            catch
            {
                return null;
            }
        }

        #region PrintFish

        /// <summary>
        /// دریافت اطلاعات سطر مورد نظر
        /// </summary>
        /// <returns></returns>
        SaleFoodOnline GetRow()
        {
            Int64 id = grd.GetFocusedRowCellValue(colSaleFoodIDFact).ToLong();
            SaleFoodReport salefood = _liSaleOnline.Where(c => c.SaleFoodIDFact == id).SingleOrDefault();
            if (salefood != null)
            {
                List<SaleFoodOnlineDetaile> saleDetailes = ServicesSaleFood.GetDetailesByIDF(id);
                salefood.FoodDetailes = saleDetailes;
            }
            return salefood;
        }
        bool PrintCustomreFish(string State, SaleFoodOnline salefood)
        {
            try
            {
                rptcustomer.DataSource = salefood;
                rptcustomer.StateFact.Value = State;
                rptcustomer.StringPrice.Value = JntNum2Text.Num2Text.ToFarsi(salefood.SumNetPrice.Value);

                if (settingServer != null)
                {
                    rptcustomer.xrLogo.Image = byteArrayToImage(settingServer.Img);
                    rptcustomer.Address.Value = settingServer.Address;
                    rptcustomer.Tell.Value = settingServer.Tell;
                    rptcustomer.motto.Value = settingServer.Motto;
                }
                rptcustomer.RequestParameters = false;
                rptcustomer.PrintingSystem.ShowMarginsWarning = true;
                var rp = new ReportPrintTool(rptcustomer);
                rp.PrinterSettings.Copies = 1;
                rp.PrinterSettings.PrinterName = _SettingPrinter.PrinterCustomer;
                rp.Print();
                //rptcustomer.CreateDocument();
                //SaleOnline.Rerport.frmPrview frm = new Rerport.frmPrview();
                //frm.documentViewer1.DocumentSource = rptcustomer;
                //frm.Show();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        bool PrintKitchen(string State, SaleFoodOnline salefood)
        {
            try
            {
                rptkithchen.DataSource = salefood;
                rptkithchen.StateFact.Value = State;
                if (settingServer != null)
                    rptkithchen.xrLogo.Image = byteArrayToImage(settingServer.Img);
                rptkithchen.RequestParameters = false;
                rptkithchen.PrintingSystem.ShowMarginsWarning = true;
                var rp = new ReportPrintTool(rptkithchen);
                rp.PrinterSettings.Copies = 1;
                rp.PrinterSettings.PrinterName = _SettingPrinter.PrinterAshpazkhane;
                rp.Print();
                //rptkithchen.CreateDocument();
                //SaleOnline.Rerport.frmPrview frm = new Rerport.frmPrview();
                //frm.documentViewer1.DocumentSource = rptkithchen;
                //frm.Show();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        void PrintCancel(string fishnumber)
        {
            try
            {

                rpCancel.StateFact.Value = string.Format($"فیش شماره {fishnumber} لغو گردید");

                rpCancel.RequestParameters = false;
                rpCancel.PrintingSystem.ShowMarginsWarning = true;
                var rp = new ReportPrintTool(rpCancel);
                rp.PrinterSettings.Copies = 1;
                rp.PrinterSettings.PrinterName = _SettingPrinter.PrinterAshpazkhane;
                rp.Print();
                rp.PrinterSettings.PrinterName = _SettingPrinter.PrinterCustomer;
                rp.Print();

                //rpCancel.CreateDocument();
                //SaleOnline.Rerport.frmPrview frm = new Rerport.frmPrview();
                //frm.documentViewer1.DocumentSource = rpCancel;
                //frm.Show();

            }
            catch (Exception ex)
            {
            }
        }

        #endregion

        #region btnPrint
        private void btnPrintKitchen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaleFoodOnline data = GetRow();
            PrintKitchen("چاپ مجدد", data);
        }

        private void btnPrintCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaleFoodOnline data = GetRow();
            PrintCustomreFish("چاپ مجدد", data);

        }

        private void btnAllPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaleFoodOnline data = GetRow();
            PrintKitchen("چاپ مجدد", data);
            PrintCustomreFish("چاپ مجدد", data);

        }


        #endregion

        private void frmOnlineSale_Load(object sender, EventArgs e)
        {
            lblVersion.Caption = "نسخه : " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread tr = new Thread(new ThreadStart(GetData));
            tr.IsBackground = true;
            tr.Start();
        }
    }
}


/*
 
    
ALTER DATABASE [SanResturant] SET ENABLE_BROKER
CREATE QUEUE NameChangeQueue;
CREATE SERVICE NameChangeService ON QUEUE NameChangeQueue ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);
GRANT SUBSCRIBE QUERY NOTIFICATIONS TO [OnlineUser];
-------------------------------------------------2
GRANT CREATE PROCEDURE TO [OnlineUser]
GRANT CREATE QUEUE TO [OnlineUser]
GRANT CREATE SERVICE TO [OnlineUser]
-----------------------------------
GRANT SELECT ON OBJECT::[SanResturant].dbo.[SaleFoodOnline] TO [OnlineUser]
GRANT RECEIVE ON QueryNotificationErrorsQueue TO [OnlineUser]
exec sp_helprotect NULL, 'OnlineUser'
     
     */
