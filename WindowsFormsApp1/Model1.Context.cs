﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_bankingEntities : DbContext
    {
        public db_bankingEntities()
            : base("name=db_bankingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin_Table> Admin_Table { get; set; }
        public virtual DbSet<Debit_Table> Debit_Table { get; set; }
        public virtual DbSet<Depotist_Table> Depotist_Table { get; set; }
        public virtual DbSet<Employee_Table> Employee_Table { get; set; }
        public virtual DbSet<FD_Table> FD_Table { get; set; }
        public virtual DbSet<Transfer_Table> Transfer_Table { get; set; }
        public virtual DbSet<UserEnd_Table> UserEnd_Table { get; set; }
        public virtual DbSet<Customer_Table> Customer_Table { get; set; }
    }
}
