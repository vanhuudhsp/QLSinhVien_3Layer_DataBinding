﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Presentation
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLSINHVIEN4Entities : DbContext
    {
        public QLSINHVIEN4Entities()
            : base("name=QLSINHVIEN4Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CHUONGTRINH> CHUONGTRINHs { get; set; }
        public DbSet<KETQUA> KETQUAs { get; set; }
        public DbSet<KHOA> KHOAs { get; set; }
        public DbSet<KHOAHOC> KHOAHOCs { get; set; }
        public DbSet<LOP> LOPs { get; set; }
        public DbSet<MONHOC> MONHOCs { get; set; }
        public DbSet<PHANQUYEN> PHANQUYENs { get; set; }
        public DbSet<SINHVIEN> SINHVIENs { get; set; }
        public DbSet<TAIKHOAN> TAIKHOANs { get; set; }
    }
}
