﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcExamTaskMitRao.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ExamEntities : DbContext
    {
        public ExamEntities()
            : base("name=ExamEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ProductMenu> ProductMenus { get; set; }
        public virtual DbSet<ProductMenuItem> ProductMenuItems { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RolesProductMenu> RolesProductMenus { get; set; }
        public virtual DbSet<RolesUser> RolesUsers { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
