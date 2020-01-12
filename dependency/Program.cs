using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace dependency
{
    class Program
    {
        /*
            ALTER DATABASE DBTest SET ENBLE_BROKER;
            CREATE QUEUE NameChangeQueue;
            CREATE SERVICE NameChangeService ON QUEUE NameChangeQueue ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);    
            --GRANT SUBSCRIBE QUERY NOTIFICATIONS TO db_owner ;
             */

        //"data source=.;initial catalog=DBTest;integrated security=True;User ID=aliuser;Password=1623456;";

        static string _conectionString = "data source=.;initial catalog=db;integrated security=True;";

        static void Main(string[] args)
        {


            GetNames();

            Console.ReadKey();
            SqlDependency.Stop(_conectionString);


        }

        private static bool CanRequestNotifications()
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

        static void GetNames()
        {
            try
            {
                if (!CanRequestNotifications())
                    return;
                SqlDependency.Stop(_conectionString);
                SqlDependency.Start(_conectionString);
                using (SqlConnection cn = new SqlConnection(_conectionString))
                {
                    using (SqlCommand cmd = cn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select ID,Name from person";
                        cmd.Notification = null;
                        //  creates a new dependency for the SqlCommand
                        SqlDependency dep = new SqlDependency(cmd);
                        dep.OnChange += new OnChangeEventHandler(dep_onchange);
                        cn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Console.WriteLine(dr.GetInt32(0) +":"+dr.GetString(1));
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
            }
        }
       static void dep_onchange(object sender, SqlNotificationEventArgs e)
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm") +
              " Info:" + e.Info +
              " Type:" + e.Type +
              " Source:" + e.Source);

            // this event is run asynchronously so you will need to invoke to run on UI thread(if required).
            //if (this.InvokeRequired)

            //    thi.BeginInvoke(new MethodInvoker(GetNames));
            //else
            GetNames();


            // this will remove the event handler since the dependency is only for a single notification
            SqlDependency dep = sender as SqlDependency;

            //  NOTE: the following code uses the normal .Net capitalization methods, though
            //      the forum software seems to change it to lowercase letters
            dep.OnChange -= new OnChangeEventHandler(dep_onchange);
        }


        private static void RegisterDependency()
        {
            using (SqlConnection connection = new SqlConnection(_conectionString))
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

                SqlCommand command = new SqlCommand("select ID,Name from person", connection) { Notification = null };
                SqlDependency dependency = new SqlDependency(command);
                dependency.OnChange += DependencyOnChange;
                connection.Open();
                SqlDataReader dr = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (dr != null)
                {

                    while (dr.Read())
                    {
                        var a = dr.GetString(1);
                        Console.WriteLine(a);
                        //SaleFoodReport fact = new SaleFoodReport();
                        //fact.ID = dr.GetInt64(0);
                        //fact.SaleFoodIDFact = dr.GetInt64(1);
                        //fact.NumFish = dr.GetString(2);
                        //fact.SaleDate = dr.GetDateTime(3);
                        //fact.SaleTime = dr.GetTimeSpan(4);
                        //fact.SumPriceBase = dr.GetInt64(5);
                        //fact.SumNet = dr.GetInt64(6);
                        //fact.SumDiscount = dr.GetInt64(7);
                        //fact.SumNetPrice = dr.GetInt64(8);
                        //fact.SumPrice = dr.GetInt64(9);
                        //fact.TypeFactor = dr.GetString(10);
                        //fact.CustomerName = dr.GetString(11);
                        //fact.CustomerTell = dr.GetString(12);
                        //fact.CustomerAddress = dr.GetString(13);
                        //fact.PrintState = dr.GetBoolean(14);
                        //fact.StateDelivery = dr.GetInt32(15);
                        //fact.Description = dr.GetString(16);
                        //AddItem(fact);
                        continue;
                    }
                    dr.Close();
                }
            }
        }

        private static void DependencyOnChange(object sender, SqlNotificationEventArgs e)
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString() +
                " Info:" + e.Info +
                " Type:" + e.Type +
                " Source:" + e.Source);
            SqlDependency dependency = (SqlDependency)sender;
            dependency.OnChange -= DependencyOnChange;
            RegisterDependency();
        }
    }
}
