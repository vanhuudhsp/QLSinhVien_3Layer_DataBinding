//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class KETQUA
    {
        public string MaSV { get; set; }
        public string MaMH { get; set; }
        public int LanThi { get; set; }
        public Nullable<double> Diem { get; set; }
    
        public virtual MONHOC MONHOC { get; set; }
        public virtual SINHVIEN SINHVIEN { get; set; }
    }
}
