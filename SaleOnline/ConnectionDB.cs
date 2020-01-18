using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Data.SqlClient;
public class ConnectionDB
{
    public static string _conectionString = "data source=.\\sqlexpress;initial catalog=SanResturant;integrated security=True;User ID=OnlineUser;Password=123456;";
    public ConnectionDB()
    {

    }
    public ConnectionDB(string connectionStr)
    {

    }


}

public static class Utilities
{

    public static string JulianDateToFarsi(DateTime date)
    {
        PersianCalendar pc = new PersianCalendar();
        var day = pc.GetDayOfMonth(date).ToString().PadLeft(2, '0');
        var month = pc.GetMonth(date).ToString().PadLeft(2, '0');
        var year = pc.GetYear(date).ToString();
        return string.Format($"{year} - {month} - {date} - {DateTime.Now.ToShortTimeString()    }");
    }
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