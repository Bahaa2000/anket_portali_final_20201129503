//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Anket_Hazirlama_Portali.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TKategori
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TKategori()
        {
            this.TSoru = new HashSet<TSoru>();
        }
    
        public int KategoriId { get; set; }
        public string KategoriTuru { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSoru> TSoru { get; set; }
    }
}