﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookStoreEntityModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BookStoreObject_Entities : DbContext
    {
        public BookStoreObject_Entities()
            : base("name=BookStoreObject_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Absence_Table> Absence_Table { get; set; }
        public virtual DbSet<Absence_Type> Absence_Type { get; set; }
        public virtual DbSet<ChechStatu> ChechStatus { get; set; }
        public virtual DbSet<CheckInDetail> CheckInDetails { get; set; }
        public virtual DbSet<Dept_Information> Dept_Information { get; set; }
        public virtual DbSet<Emp_AttendancyType> Emp_AttendancyType { get; set; }
        public virtual DbSet<Emp_Authority> Emp_Authority { get; set; }
        public virtual DbSet<Emp_Information> Emp_Information { get; set; }
        public virtual DbSet<Emp_Occupation> Emp_Occupation { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<reimbursement> reimbursements { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Cmp_Information> Cmp_Information { get; set; }
    }
}
