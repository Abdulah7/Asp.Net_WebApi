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
    public class KvaroviController : ApiController
    {

        AutoSalonEntities ctx = new AutoSalonEntities();
        [HttpGet]
        [HttpPost]
        public KvaroviVM GetAllKvarovi()
        {
            KvaroviVM model = new KvaroviVM
            {
                info = ctx.Kvarovi.Select(x => new KvaroviVM.KvaroviInfo
                {
                    KvarID = x.KvarID,
                    Opis = x.Opis,
                    KupacID = x.KupacID

                }).ToList()
            };
            return model;
        }
    }
}
