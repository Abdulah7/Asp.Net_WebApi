using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;

using SalonAuta.Data;
using System.Web.Http;
using System.Web.Http.Description;
using SalonAuta.WebApi.Models;
namespace SalonAuta.WebApi.Controllers
{
    public class PitanjaController : ApiController
    {

        AutoSalonEntities ctx = new AutoSalonEntities();


 
       [HttpPost]
        public IHttpActionResult Post(PitanjaVM p)
        {
            Pitanja n = new Pitanja();
            
                n.Opis = p.Opis;
                n.KupacID = p.KupacID;

            ctx.Pitanja.Add(n);
            ctx.SaveChanges();
            return Ok();
        }
            
[HttpPost]
        [HttpGet]
        public IHttpActionResult Post2(int KupacID, string Opis)
        {
            Pitanja n = new Pitanja();
            
                n.Opis = Opis;
                n.KupacID = KupacID;

            ctx.Pitanja.Add(n);
            ctx.SaveChanges();
            return Ok();
        }
    }
}
