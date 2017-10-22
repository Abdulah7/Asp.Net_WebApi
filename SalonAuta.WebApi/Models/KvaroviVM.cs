using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalonAuta.WebApi.Models
{
    public class KvaroviVM
    {

        public List<KvaroviInfo> info { get; set; }

        public class KvaroviInfo
        {
        public int KvarID { get; set; }
        public string Opis { get; set; }
        public int KupacID { get; set; }
    }

    }
}