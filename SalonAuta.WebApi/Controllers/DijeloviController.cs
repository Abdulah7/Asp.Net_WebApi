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
    public class DijeloviController : ApiController
    {

        AutoSalonEntities ctx = new AutoSalonEntities();
        [HttpGet]
        public DijeloviAll getDijelovi()
        {

            DijeloviAll model = new DijeloviAll
            {
                info = ctx.Dijelovi.Select(x => new DijeloviAll.DijeloviInfo
                {
                    DioID= x.DioID,
                    Naziv = x.Naziv,
                    Zalihe = x.Zalihe,

                    Cijena = x.Cijena,
                    Sifra = x.Sifra,
                   ProizvodjacID = x.ProizvodjacID,
                    AutaProizvedena = x.AutaProizvedena,
                    Opis =x.Opis
                 
                


                }).ToList()
            };
            return model;

        }
    }
}
