﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFEatTracker
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EatTrackerEntities : DbContext
    {
        public EatTrackerEntities()
            : base("name=EatTrackerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Activity> Activity { get; set; }
        public virtual DbSet<Breakfast> Breakfast { get; set; }
        public virtual DbSet<Dinner> Dinner { get; set; }
        public virtual DbSet<Lunch> Lunch { get; set; }
        public virtual DbSet<OtherEat> OtherEat { get; set; }
        public virtual DbSet<Person> Person { get; set; }
    }
}