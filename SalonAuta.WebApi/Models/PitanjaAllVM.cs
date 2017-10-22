using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SalonAuta.Data;
namespace SalonAuta.WebApi.Models
{
    public class PitanjaAllVM
    {
        public List<PitanjaInfo> info { get; set; }
        public class PitanjaInfo

        {
            public int PitanjeID { get; set; }
            public string Opis { get; set; }
            public int KupacID { get; set; }

        }
    }
}