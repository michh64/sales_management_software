//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sales_management_software
{
    using System;
    using System.Collections.Generic;
    
    public partial class THONG_SO_KY_THUAT
    {
        public string mats { get; set; }
        public string tents { get; set; }
        public string masp { get; set; }
        public string giatri { get; set; }
        public Nullable<bool> deleted { get; set; }
    
        public virtual SAN_PHAM SAN_PHAM { get; set; }
    }
}