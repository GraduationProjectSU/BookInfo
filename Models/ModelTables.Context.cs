﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookInfo.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntitiesTables : DbContext
    {
        public EntitiesTables()
            : base("name=EntitiesTables")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<kitap_diller> kitap_diller { get; set; }
        public virtual DbSet<kitap_turler> kitap_turler { get; set; }
        public virtual DbSet<kitaplar> kitaplars { get; set; }
        public virtual DbSet<kullanicilar> kullanicilars { get; set; }
    }
}