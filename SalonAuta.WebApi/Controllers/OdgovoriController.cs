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
    public class OdgovoriController : ApiController
    {

        AutoSalonEntities ctx = new AutoSalonEntities();
        [HttpGet]
        public OdgovoriVM GetOdgovori()
        {
            OdgovoriVM o = new OdgovoriVM();
            o.info = ctx.Notifikacija.Select(x => new OdgovoriVM.OdgovriInfo
            {

                Naslov = x.Naslov,
                Opis = x.Opis

            }).ToList();
            return o;

        }
    }
}
