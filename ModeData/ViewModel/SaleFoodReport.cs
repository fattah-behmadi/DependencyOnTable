using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeData.ModelDomain;
using System.Globalization;
public class SaleFoodReport : SaleFoodOnline
{

    public string PrintStatelbl
    {
        get
        {

            return this.PrintState.Value == true ? "چاپ شده" : "چاپ نشده";
        }
    }
    public string StateFact
    {
        get
        {

            string state = "";
            switch (this.StateDelivery)
            {
                case 0:
                    state = "ثبت جدید";
                    break;
                case 1:
                    state = "ویرایش شده";
                    break;
                case 2:
                    state = "لغو شده";
                    break;
            }
            return state;
        }
    }

    public string SaleDateSH
    {
        get
        {

            return func.EnDateToPersianDate(this.SaleDate.Value);
        }
    }

    public List<SaleFoodOnlineDetaile> FoodDetailes { get; set; }

}

static class func
{
    public static string EnDateToPersianDate(DateTime dt)
    {
        PersianCalendar pc = new PersianCalendar();
        return string.Format($"{ pc.GetYear(dt)}-{pc.GetMonth(dt)}-{ pc.GetDayOfMonth(dt)}");
    }
}