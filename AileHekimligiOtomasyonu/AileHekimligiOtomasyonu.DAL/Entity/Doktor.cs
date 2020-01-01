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
    
    public partial class Doktor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doktor()
        {
            this.Muayenes = new HashSet<Muayene>();
            this.Randevus = new HashSet<Randevu>();
        }
    
        public int DoktorId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int SaglikOcagiId { get; set; }
    
        public virtual SaglikOcagi SaglikOcagi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Muayene> Muayenes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Randevu> Randevus { get; set; }
    }
}
