using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableDependency.SqlClient;

using ModeData.ModelDomain;
using TableDependency.SqlClient.Base.EventArgs;
using TableDependency.SqlClient.Base;
using TableDependency.Enums;
using System.Data.SqlClient;

namespace SaleOnline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
     
        }

        string _con;
        SqlTableDependency<SaleFoodOnline> _dependency;
        private void btnStart_Click(object sender, EventArgs e)
        {
            SanResturantEntities db = new SanResturantEntities();
            var li = db.SaleFoodOnline.ToList();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from SaleFoodOnline", new SqlConnection(_con));
            da.Fill(dt);

            var co = dt.Rows.Count;

            //var dep = new SqlTableDependency<SaleFoodOnline>(_con, "SaleFoodOnline");
            //dep.OnChanged += Changed;
            //dep.OnError += _dependency_OnError;
            //dep.Start();
            //btnStop.Enabled = true;

            var mapper = new ModelToTableMapper<SaleFoodOnline>();
            mapper.AddMapping(model => model.ID, "ID");
            _dependency = new SqlTableDependency<SaleFoodOnline>(_con, "SaleFoodOnline", "dbo", mapper);
            _dependency.OnChanged += Changed;
            _dependency.OnError += _dependency_OnError;
            _dependency.Start();

        }

        public void Changed(object sender, RecordChangedEventArgs<SaleFoodOnline> e)
        {
            MessageBox.Show("Test");
            var changedEntity = e.Entity;

            Console.WriteLine("DML operation: " + e.ChangeType);
            GetList(changedEntity);
            //Console.WriteLine("SaleFoodIDFact: " + changedEntity.SaleFoodIDFact);
            //Console.WriteLine("CustomerName: " + changedEntity.CustomerName);
        }
        void _dependency_OnError(object sender, ErrorEventArgs e)
        {
            Exception ex = e.Error;
            throw e.Error;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            //dep.Stop();
            btnStop.Enabled = false;

        }

        List<SaleFoodOnline> li = new List<SaleFoodOnline>();
        void GetList(SaleFoodOnline fact)
        {
            li.Add(fact);
            gridControl1.DataSource = null;
            gridControl1.DataSource = li;
        }


        public void WatchTable()
        {
            //var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnString"].ConnectionString;

            var tableName = "[dbo].[SaleFoodOnline]";
            var tableDependency = new SqlTableDependency<SaleFoodOnline>(_con, tableName);
            //tableDependency.OnChanged += OnNotificationReceived;
            tableDependency.Start();
        }

        private void OnNotificationReceived(object sender, TableDependency.EventArgs.RecordChangedEventArgs<SaleFoodOnline> e)
        {
            switch (e.ChangeType)
            {
                case ChangeType.Delete:
                    GetList(e.Entity);
                    break;

                case ChangeType.Update:
                    GetList(e.Entity);

                    break;

                case ChangeType.Insert:
                    GetList(e.Entity);

                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SanResturantEntities db = new SanResturantEntities();
            var sf = db.SaleFoodOnline.ToList().FirstOrDefault();
            if (sf != null)
                db.SaleFoodOnline.Remove(sf);
            db.SaveChanges();


        }
    }
}
