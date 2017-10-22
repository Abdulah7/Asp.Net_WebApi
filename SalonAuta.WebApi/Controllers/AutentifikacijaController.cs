using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SalonAuta.Data;
using SalonAuta.WebApi.Models;
namespace SalonAuta.WebApi.Controllers
{
    public class AutentifikacijaController : ApiController
    {
        private AutoSalonEntities ctx = new AutoSalonEntities();

        [HttpGet]
        public AutentifikacijaProvjeraVM Provjera(string email, string lozinka)
        {
            AutentifikacijaProvjeraVM model = ctx.Kupci.Where(x => x.Email == email && x.Lozinka == lozinka)
                .Select(x => new AutentifikacijaProvjeraVM
                {
                    Kupci = x.KupacID,
                    Email = x.Email,
                    Lozinka = x.Lozinka,



                }).FirstOrDefault();

            return model;
        }
    }


}
