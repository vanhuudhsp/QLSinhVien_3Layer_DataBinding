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
    
    public partial class KHOAHOC
    {
        public KHOAHOC()
        {
            this.LOPs = new HashSet<LOP>();
        }
    
        public string MaKhoaHoc { get; set; }
        public Nullable<int> NamBatDau { get; set; }
        public Nullable<int> NamKetThuc { get; set; }
    
        public virtual ICollection<LOP> LOPs { get; set; }
    }
}
