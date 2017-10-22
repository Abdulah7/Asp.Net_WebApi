using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalonAuta.WebApi.Models
{
    public class OdgovoriVM
    {

        public List<OdgovriInfo> info { get; set; }

        public class OdgovriInfo
        {
            public string Naslov { get; set; }
            public string Opis { get; set; }
        }
    }
}