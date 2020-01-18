using ModeData.ModelDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ServicesSaleFood
{
    static RepoSaleFood repo = new RepoSaleFood();


    public static SaleFoodOnline GetSalefood(Int64 idfact)
    {
        return repo.GetSalefood(idfact);
    }
    public static List<SaleFoodOnlineDetaile> GetDetailesByIDF(Int64 idfact)
    {
        return repo.GetDetailesByIDF(idfact);
    }

    public static int UpdateSaleFoodOnline(SaleFoodOnline salefood)
    {
        return repo.UpdateSaleFoodOnline(salefood);
    }

    static SettingServerOnline serverSetting;
    public static SettingServerOnline GetSettingServer()
    {
        if (serverSetting == null)
            serverSetting = repo.ServerSetting();
        return serverSetting;
    }

    public static tblPrinterUserSetting GetSettingPrinter()
    {
        return repo.GetSettingPrinter();
    }


}
