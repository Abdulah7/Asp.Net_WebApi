using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalonAuta.WebApi.Models
{
    public class DijeloviAll
    {

        public List<DijeloviInfo> info { get; set; }

        public class DijeloviInfo

        {
            public int DioID { get; set; }
            public string Naziv { get; set; }
            public int Zalihe { get; set; }
            public double Cijena { get; set; }
            public string Sifra { get; set; }
            public int ProizvodjacID { get; set; }
            public string AutaProizvedena { get; set; }
            public string Opis{ get; set; }
        }
    }
}