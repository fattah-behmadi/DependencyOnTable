using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
public class ConnectionDB
{
    public static string _conectionString = "data source=.;initial catalog=SanResturant;integrated security=True;User ID=OnlineUser;Password=123456;";
    SqlConnection con = new SqlConnection();
    public ConnectionDB()
    {
        con.ConnectionString = _conectionString;
    }
    public ConnectionDB(string connectionStr)
    {
        con.ConnectionString = connectionStr;
    }
    public static void GetData()
    {

    }



}

public static class  Utilities
{

    public static int ToInt(this object obj)
    {
        if (obj == null) return 0;
        return Convert.ToInt32(obj);
    }

    public static long ToLong(this object obj)
    {
        if (obj == null) return 0;
        return Convert.ToInt64(obj);
    }
    public static int ToInt(this string obj)
    {
        if (string.IsNullOrEmpty(obj)) return 0;
        if (obj == null) return 0;
        return Convert.ToInt32(obj);
    }

}