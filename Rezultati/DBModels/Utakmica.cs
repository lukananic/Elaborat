//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rezultati.DBModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Utakmica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Utakmica()
        {
            this.Ucinaks = new HashSet<Ucinak>();
        }
    
        public int UtakmicaID { get; set; }
        public System.DateTime Datum { get; set; }
        public int Kolo { get; set; }
        public int DomaciTimID { get; set; }
        public int GostujuciTimID { get; set; }
        public bool Odigrana { get; set; }
        public int DomacinGolovi { get; set; }
        public int GostGolovi { get; set; }
        public bool Traje { get; set; }
    
        public virtual Tim Tim { get; set; }
        public virtual Tim Tim1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ucinak> Ucinaks { get; set; }
    }
}
