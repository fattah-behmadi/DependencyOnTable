﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModeData.ModelDomain
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SanResturantEntities : DbContext
    {
        public SanResturantEntities()
            : base("name=SanResturantEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<SaleFoodOnline> SaleFoodOnline { get; set; }
        public virtual DbSet<SaleFoodOnlineDetaile> SaleFoodOnlineDetaile { get; set; }
        public virtual DbSet<SettingServerOnline> SettingServerOnline { get; set; }
    }
}