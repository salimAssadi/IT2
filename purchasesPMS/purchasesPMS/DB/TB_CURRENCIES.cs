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
    
    public partial class TB_CURRENCIES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_CURRENCIES()
        {
            this.TB_PURCHASES = new HashSet<TB_PURCHASES>();
        }
    
        public int cur_id { get; set; }
        public string cur_name { get; set; }
        public decimal curr_value { get; set; }
        public Nullable<byte> is_locale { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PURCHASES> TB_PURCHASES { get; set; }
    }
}