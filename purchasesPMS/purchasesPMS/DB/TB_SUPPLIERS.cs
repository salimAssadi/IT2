//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace purchasesPMS.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_SUPPLIERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_SUPPLIERS()
        {
            this.TB_PURCHASES = new HashSet<TB_PURCHASES>();
        }
    
        public int supplier_id { get; set; }
        public string supplier_name { get; set; }
        public decimal supplier_phone { get; set; }
        public string supplier_email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PURCHASES> TB_PURCHASES { get; set; }
    }
}
