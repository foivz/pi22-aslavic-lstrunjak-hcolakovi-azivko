﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Forme.Baza_podataka
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PI2229_DBEntities : DbContext
    {
        public PI2229_DBEntities()
            : base("name=PI2229_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Autoprijevoznik> Autoprijevoznik { get; set; }
        public virtual DbSet<Karta> Karta { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<Linija> Linija { get; set; }
        public virtual DbSet<Uloga_korisnika> Uloga_korisnika { get; set; }
    }
}
