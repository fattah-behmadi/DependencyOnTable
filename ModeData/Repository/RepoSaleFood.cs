using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ModeData.ModelDomain;
internal class RepoSaleFood
{

    internal RepoSaleFood()
    {
    }
    ModeData.ModelDomain.SanResturantEntities db = new ModeData.ModelDomain.SanResturantEntities();
    internal SaleFoodOnline GetSalefood(Int64 idfact)
    {
        return db.SaleFoodOnline.Where(c => c.SaleFoodIDFact == idfact).SingleOrDefault();
    }
    internal List<SaleFoodOnlineDetaile> GetDetailesByIDF(Int64 idfact)
    {
        return db.SaleFoodOnlineDetaile.Where(c => c.SaleFoodID == idfact).ToList();
    }

    internal int UpdateSaleFoodOnline(SaleFoodOnline salefood)
    {
        db.Entry(salefood).State = System.Data.Entity.EntityState.Modified;
        return db.SaveChanges();
    }

    internal SettingServerOnline ServerSetting()
    {
        return db.SettingServerOnline.FirstOrDefault();
    }
}
