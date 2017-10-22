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
    public class AutaController : ApiController
    {

        AutoSalonEntities ctx = new AutoSalonEntities();
        [HttpGet]
        public AutaAllVM getAuta()
        {

            AutaAllVM model = new AutaAllVM();

            model.info = ctx.Vozila.Select(x => new AutaAllVM.Autainfo
            {
                VoziloID = x.VoziloID,
                Naziv = x.Naziv,
                Godiste = x.Godiste,
                Boja = x.Boja,
                VrstaMotora = x.VrstaMotora,
                EmisijaCO2 = x.EmisijaCO2,
                ModelID = x.ModelID,
               Slika = x.Slika,
                Cijena = x.Cijena,
                Oprema = x.Oprema,
                SnagaMotora = x.SnagaMotora,
                BrojSasije = x.BrojSasije,
                ZapreminaMotora = x.ZapreminaMotora,
                ZapreminaGepeka = x.ZapreminaGepeka,
                Duzina = x.Duzina,
                Tezina = x.Tezina,
                Klima = x.Klima,
                BrojSjedista = x.BrojSjedista,
                Pogon = x.Pogon,
                BrojVrata = x.BrojVrata,
                OpisSigurnost = x.OpisSigurnost,
                Mijenjac = x.Mijenjac,
                Potrosnja = x.Potrosnja,
                ObrtniMoment = x.ObrtniMoment,
                Sirina = x.Sirina,
                Ubrzanje = x.Ubrzanje,
                MaksimalnaBrzina = x.MaksimalnaBrzina,
                Kolicina = x.Kolicina




            }).ToList();
            
            return model;

        }
    }
}