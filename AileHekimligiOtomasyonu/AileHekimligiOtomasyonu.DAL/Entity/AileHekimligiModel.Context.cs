﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AileHekimligiOtomasyonu.DAL.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AileHekimligidbEntities : DbContext
    {
        public AileHekimligidbEntities()
            : base("name=AileHekimligidbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Doktor> Doktors { get; set; }
        public virtual DbSet<Ilac> Ilacs { get; set; }
        public virtual DbSet<Muayene> Muayenes { get; set; }
        public virtual DbSet<Randevu> Randevus { get; set; }
        public virtual DbSet<SaglikOcagi> SaglikOcagis { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tani> Tanis { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Hasta> Hastas { get; set; }
    }
}