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
    
    public partial class Dijelovi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dijelovi()
        {
            this.RacuniStavke = new HashSet<RacuniStavke>();
        }
    
        public int DioID { get; set; }
        public string Naziv { get; set; }
        public int Zalihe { get; set; }
        public double Cijena { get; set; }
        public string Sifra { get; set; }
        public int ProizvodjacID { get; set; }
        public string AutaProizvedena { get; set; }
        public string Opis { get; set; }
    
        public virtual Proizvodjaci Proizvodjaci { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RacuniStavke> RacuniStavke { get; set; }
    }
}
