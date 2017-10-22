using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalonAuta.WebApi.Models
{
    public class NotifikacijaPregledVM
    {

        public NotifikacijaInfoVM LastNotifikacija { get; set; }
        public int CountNotifikacije { get; set; }

        public class NotifikacijaInfoVM
        {
            public string Naslov { get; set; }
            public string Opis { get; set; }
        }
    }
}