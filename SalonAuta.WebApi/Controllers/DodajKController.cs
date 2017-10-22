using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SalonAuta.WebApi.Models;
using SalonAuta.Data;
namespace SalonAuta.WebApi.Controllers
{
    public class DodajKController : ApiController
    {

        AutoSalonEntities ctx = new AutoSalonEntities();



        [HttpPost]
        public IHttpActionResult Post(KvarVM p)
        {
            Kvarovi n = new Kvarovi();

            n.Opis = p.Opis;
            n.KupacID = p.KupacID;

            ctx.Kvarovi.Add(n);
            ctx.SaveChanges();
            return Ok();
        }

        [HttpPost]
        [HttpGet]
        public IHttpActionResult Post2(int KupacID, string Opis)
        {
            Kvarovi n = new Kvarovi();

            n.Opis = Opis;
            n.KupacID = KupacID;

            ctx.Kvarovi.Add(n);
            ctx.SaveChanges();
            return Ok();
        }
    }
}
