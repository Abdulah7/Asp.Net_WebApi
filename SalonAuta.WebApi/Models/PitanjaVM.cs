using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalonAuta.WebApi.Models
{
    public class PitanjaVM
    { 
        public int PitanjeID { get; set; }
        public string Opis { get; set; }
        public int KupacID { get; set; }
    }
}