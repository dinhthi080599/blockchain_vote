//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSharpchainWebAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_hoadonnhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_hoadonnhap()
        {
            this.tbl_chitiethoadonnhap = new HashSet<tbl_chitiethoadonnhap>();
        }
    
        public int imaHDNhap { get; set; }
        public Nullable<int> iMaNguoiLap { get; set; }
        public Nullable<System.DateTime> dThoiGianLap { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_chitiethoadonnhap> tbl_chitiethoadonnhap { get; set; }
        public virtual tbl_taikhoan tbl_taikhoan { get; set; }
    }
}