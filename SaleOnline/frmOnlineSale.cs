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

/// <summary>
/// https://chartio.com/help/data-sources/granting-table-level-permissions-in-sql-server/
/// </summary>
namespace SaleOnline
{
    public partial class frmOnlineSale : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        List<SaleFoodReport> _liSaleOnline;
        public frmOnlineSale()
        {
            InitializeComponent();
            GetData();
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



        #region MyRegion

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

        private void GetData()
        {
            string sql = @"SELECT [ID]
                                              ,[SaleFoodIDFact]
                                              ,[NumFish]
                                              ,[SaleDate]
                                              ,[SaleTime]
                                              ,[SumPriceBase]
                                              ,[SumNet]
                                              ,[SumDiscount]
                                              ,[SumNetPrice]
                                              ,[SumPrice]
                                              ,[TypeFactor]
                                              ,[CustomerName]
                                              ,[CustomerTell]
                                              ,[CustomerAddress]
                                              ,[PrintState]
                                              ,[StateDelivery]
                                              ,[Description]
                                             FROM [dbo].[SaleFoodOnline]";

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
        /// ثبت آیتم در لیست
        /// </summary>
        /// <param name="sale">فاکتور</param>
        void AddItem(SaleFoodReport sale)
        {
            if (_liSaleOnline == null)
                _liSaleOnline = new List<SaleFoodReport>();

            _liSaleOnline.Add(sale);
            gridControl1.DataSource = _liSaleOnline.OrderByDescending(c => c.ID);
            grd.BestFitColumns();

            lblCountCanceled.Caption = "لغوی  " + _liSaleOnline.Where(c => c.StateDelivery == 2).ToList().Count;
            lblCountEdit.Caption = "ویرایش  " + _liSaleOnline.Where(c => c.StateDelivery == 1).ToList().Count;
            lblCountNew.Caption = "جدید  " + _liSaleOnline.Where(c => c.StateDelivery == 0).ToList().Count;


        }
        /// <summary>
        /// مانیتور دیتابیس
        /// </summary>
        void dep_onchange(object sender, SqlNotificationEventArgs e)
        {
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

        private void btnPrintKitchen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RptKitchen rpt = new RptKitchen();
            rpt.DataSource = GetRow();
            rpt.StateFact.Value = "جدید";
            rpt.xrLogo.Image = byteArrayToImage(ServicesSaleFood.GetSettingServer().Img);
            rpt.CreateDocument();
            SaleOnline.Rerport.frmPrview frm = new Rerport.frmPrview();
            frm.documentViewer1.DocumentSource = rpt;
            frm.Show();

        }
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

        private void btnPrintCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SettingServerOnline settingServer = ServicesSaleFood.GetSettingServer();

            RptCustomer rpt = new RptCustomer();
            SaleFoodOnline data = GetRow();
            rpt.DataSource = data;

            rpt.StateFact.Value = "جدید";
            rpt.StringPrice.Value = JntNum2Text.Num2Text.ToFarsi(data.SumNetPrice.Value);
            rpt.xrLogo.Image = byteArrayToImage(settingServer.Img);
            rpt.Address.Value = settingServer.Address;
            rpt.Tell.Value = settingServer.Tell;
            rpt.motto.Value = settingServer.Motto;

            rpt.CreateDocument();
            SaleOnline.Rerport.frmPrview frm = new Rerport.frmPrview();
            frm.documentViewer1.DocumentSource = rpt;
            frm.Show();

        }
    }
}
