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
    public class NotifikacijaController : ApiController
    {
        AutoSalonEntities ctx = new AutoSalonEntities();

        [HttpGet]
        public NotifikacijaPregledVM Pregled(int kupac)
        {
            IQueryable<Notifikacija> notifikacijas = ctx.Notifikacija.Where(x => x.KupacID == kupac && !x.IsRead);
            NotifikacijaPregledVM model = new NotifikacijaPregledVM
            {
                LastNotifikacija = notifikacijas
                .OrderByDescending(x => x.Vrijeme)
                   .Select(x => new NotifikacijaPregledVM.NotifikacijaInfoVM
                   {
                       Naslov = x.Naslov,
                       Opis = x.Opis
                   }).FirstOrDefault(),
                CountNotifikacije = notifikacijas.Count()
            };

            return model;
        }

    }
}
