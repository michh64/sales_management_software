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
    
    public partial class HOA_DON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOA_DON()
        {
            this.DON_HANG = new HashSet<DON_HANG>();
        }
    
        public string mahd { get; set; }
        public string masp { get; set; }
        public string tensp { get; set; }
        public Nullable<int> dongia { get; set; }
        public Nullable<int> giamgia { get; set; }
        public Nullable<int> soluong { get; set; }
        public Nullable<int> tongtien { get; set; }
        public Nullable<bool> deleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DON_HANG> DON_HANG { get; set; }
        public virtual SAN_PHAM SAN_PHAM { get; set; }
    }
}
