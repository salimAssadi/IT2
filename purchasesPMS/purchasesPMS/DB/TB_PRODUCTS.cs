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
    
    public partial class TB_PRODUCTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_PRODUCTS()
        {
            this.Purchase_Items = new HashSet<Purchase_Items>();
            this.TB_STOCKS = new HashSet<TB_STOCKS>();
        }
    
        public int Prod_id { get; set; }
        public string Prod_name { get; set; }
        public decimal Unite_price { get; set; }
        public string SN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase_Items> Purchase_Items { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_STOCKS> TB_STOCKS { get; set; }
    }
}