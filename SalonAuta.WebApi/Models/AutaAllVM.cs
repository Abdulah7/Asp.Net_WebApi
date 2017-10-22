using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalonAuta.WebApi.Models
{
    public class AutaAllVM
    {
        public List<Autainfo> info { get; set; }
        public class Autainfo
        {
            public int VoziloID { get; set; }
            public string Naziv { get; set; }
            public string Godiste { get; set; }
            public string Boja { get; set; }
            public string VrstaMotora { get; set; }
            public string EmisijaCO2 { get; set; }
            public int ModelID { get; set; }
            //public byte[] SlikaThumg { get; set; }
            public byte[] Slika { get; set; }
            public double Cijena { get; set; }
            public string Oprema { get; set; }
            public string SnagaMotora { get; set; }
            public string BrojSasije { get; set; }
            public string ZapreminaMotora { get; set; }
            public string ZapreminaGepeka { get; set; }
            public string Duzina { get; set; }
            public string Tezina { get; set; }
            public string Klima { get; set; }
            public Nullable<int> BrojSjedista { get; set; }
            public string Pogon { get; set; }
            public Nullable<int> BrojVrata { get; set; }
            public string OpisSigurnost { get; set; }
            public string Mijenjac { get; set; }
            public string Potrosnja { get; set; }
            public string ObrtniMoment { get; set; }
            public string Sirina { get; set; }
            public string Ubrzanje { get; set; }
            public string MaksimalnaBrzina { get; set; }
            public Nullable<int> Kolicina { get; set; }
        }

    }
}