//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SalonAuta.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Racuni
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Racuni()
        {
            this.RacuniStavke = new HashSet<RacuniStavke>();
        }
    
        public int RacunID { get; set; }
        public int KorisnikID { get; set; }
        public double Cijena { get; set; }
        public string Komentar { get; set; }
        public double PDV { get; set; }
        public double Ukupno { get; set; }
        public System.DateTime DatumFakture { get; set; }
        public Nullable<System.DateTime> DatumIsporuke { get; set; }
        public string NacinIsporuke { get; set; }
        public int PlacanjeID { get; set; }
        public int KupacID { get; set; }
    
        public virtual Korisnici Korisnici { get; set; }
        public virtual Kupci Kupci { get; set; }
        public virtual NaciniPlacanja NaciniPlacanja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RacuniStavke> RacuniStavke { get; set; }
    }
}
