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
    
    public partial class tbl_chitiethoadonnhap
    {
        public int imaHDNhap { get; set; }
        public Nullable<int> imaHD { get; set; }
        public int imaSP { get; set; }
        public Nullable<int> iGiaNhap { get; set; }
        public Nullable<int> iSoLuong { get; set; }
    
        public virtual tbl_hoadonnhap tbl_hoadonnhap { get; set; }
        public virtual tbl_menu tbl_menu { get; set; }
    }
}
