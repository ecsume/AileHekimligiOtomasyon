//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AileHekimligiOtomasyonu.DAL.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ilac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ilac()
        {
            this.Muayenes = new HashSet<Muayene>();
        }
    
        public int IlacId { get; set; }
        public string IlacAdi { get; set; }
        public string Dozaj { get; set; }
        public int KullanimSuresi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Muayene> Muayenes { get; set; }
    }
}
