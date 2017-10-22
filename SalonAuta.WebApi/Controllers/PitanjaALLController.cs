using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SalonAuta.WebApi.Models;
using SalonAuta.Data;
namespace SalonAuta.WebApi.Models
{
    public class PitanjaALLController : ApiController
    {
        AutoSalonEntities ctx = new AutoSalonEntities();
      [HttpGet]
        [HttpPost]
        public PitanjaAllVM GetAllPitanja()
        {
            PitanjaAllVM model = new PitanjaAllVM
            {
                info = ctx.Pitanja.Select(x => new PitanjaAllVM.PitanjaInfo
                {
                    PitanjeID = x.PitanjeID,
                    Opis = x.Opis,
                    KupacID = x.KupacID

                }).ToList(),


                
            };
            return model;
        }
    }
}
