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
    
    public partial class KHOA
    {
        public KHOA()
        {
            this.LOPs = new HashSet<LOP>();
            this.MONHOCs = new HashSet<MONHOC>();
        }
    
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public Nullable<int> NamThanhLap { get; set; }
    
        public virtual ICollection<LOP> LOPs { get; set; }
        public virtual ICollection<MONHOC> MONHOCs { get; set; }
    }
}
