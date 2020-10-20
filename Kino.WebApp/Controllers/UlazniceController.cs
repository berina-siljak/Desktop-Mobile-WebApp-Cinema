using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kino.Model.Requests;
using Kino.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kino.WebApp.Controllers
{
    public class UlazniceController : Controller
    {
        APIService _kupacService = new APIService("Kupci");
        APIService _filmoviService = new APIService("Filmovi");
        APIService _projekcijeService = new APIService("Projekcije");
        APIService _ulazniceService = new APIService("Ulaznice");
        APIService _sjedistaService = new APIService("Sjedista");
        APIService _saleService = new APIService("Sale");
        UlazniceInsertRequest request = new UlazniceInsertRequest();

        // GET: /<controller>/
   
        public async Task<IActionResult> Index()
        {
            var model = (await _ulazniceService.Get<List<Model.Ulaznice>>(null)).Select(x => new UlazniceViewModel(x)).ToList();
            return View("Ulaznice", model);
        }


        public async Task<IActionResult> Detalji()
        {
            var model = new UlazniceViewModel();
            ViewBag.Kupci = new SelectList(await _kupacService.Get<List<Model.Kupci>>(null), "KupacID", "ImePrezimeKupca");
            ViewBag.Filmovi = new SelectList(await _filmoviService.Get<List<Model.Filmovi>>(null), "FilmID", "Naziv");
            ViewBag.Projekcije = Enumerable.Empty<SelectListItem>();
            //ViewBag.Projekcije = new SelectList(await _projekcijeSevrvice.Get<List<Model.Projekcije>>(null), "ProjekcijaID", "Datum");
            model.Datum = DateTime.Now;
            return View("UlazniceDetalji",model);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var model = new UlazniceViewModel(await _ulazniceService.GetById<Model.Ulaznice>(id));
            ViewBag.Kupci = new SelectList(await _kupacService.Get<List<Model.Kupci>>(null), "KupacID", "ImePrezimeKupca");
            ViewBag.Filmovi = new SelectList(await _filmoviService.Get<List<Model.Filmovi>>(null), "FilmID", "Naziv");
            ViewBag.Projekcije = Enumerable.Empty<SelectListItem>();
            
            //ViewBag.Projekcije = new SelectList(await _projekcijeService.Get<List<Model.Projekcije>>(new ProjekcijeSearchRequest()
            //                    {
            //                        FilmID = model.ProjekcijaID,
            //                        sveProjekcije = true
            //                    }), "ProjekcijaID", "Datum");

            return View("UlazniceDetalji", model);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var model = new UlazniceViewModel(await _ulazniceService.Delete<Model.Ulaznice>(id));
            return RedirectToAction("Index");
        }
        //public async Task<IActionResult> Edit(int id)
        //{

        //    var model = new UlazniceViewModel(await _ulazniceService.GetById<Model.Ulaznice>(id));
        //    return View("UlazniceDetalji", model);
        //}
        public async Task<IActionResult> Snimi(UlazniceViewModel model)
        {
            //request.ProjekcijaID = model.ProjekcijaID;
            request.KupacID = model.KupacID;
            request.SjedisteID = model.SjedisteID;
            request.Datum = model.Datum;
            request.Datum = model.Datum.Date + model.Vrijeme.TimeOfDay;
            request.Popust = model.Popust;
            

            if (model.ProjekcijaID != 0)
            {

                request.ProjekcijaID = model.ProjekcijaID;
                var projekcija = new ProjekcijeViewModel(await _projekcijeService.GetById<Model.Projekcije>(model.ProjekcijaID));
                request.CijenaSaPopustom = projekcija.Cijena - (projekcija.Cijena * model.Popust / 100);

            }
            //if (model.FilmID != 0)
            //    request.FilmID = model.FilmID;

            if (model.KupacID != 0)
                request.KupacID = model.KupacID;
            if (model.UlaznicaID != null)
            {
                try
                {
                    await _ulazniceService.Update<Model.Ulaznice>(model.UlaznicaID.Value, request);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                try
                {
                    await _ulazniceService.Insert<Model.Ulaznice>(request);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            ViewBag.Kupci = new SelectList(await _kupacService.Get<List<Model.Kupci>>(null), "KupacID", "ImePrezimeKupca");
            ViewBag.Filmovi = new SelectList(await _filmoviService.Get<List<Model.Filmovi>>(null), "FilmID", "Naziv");
            ViewBag.Projekcije = Enumerable.Empty<SelectListItem>();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> GetProjekcijeByProjekcijaId(int id)
        {
            var projekcija = new ProjekcijeViewModel(await _projekcijeService.GetById<Model.Projekcije>(id));
            var sjedista = new SjedistaViewModel(await _sjedistaService.GetById<Model.Sjedista>(projekcija.SalaID));
            SjedistaSearchRequest search = new SjedistaSearchRequest();
            search.SalaID = projekcija.SalaID;
            var listaSjedista = (await _sjedistaService.Get<List<Model.Sjedista>>(search)).Select(x => new SjedistaViewModel(x)).ToList();
            ProjekcijeSjedistaViewModel model = new ProjekcijeSjedistaViewModel();
            UlazniceSearchRequest search2 = new UlazniceSearchRequest();
            search2.ProjekcijaID = projekcija.ProjekcijaID;
            var ulaznice = (await _ulazniceService.Get<List<Model.Ulaznice>>(search2)).Select(x => new UlazniceViewModel(x)).ToList();
            foreach (var ulaznica in ulaznice)
            {
                var odabranoSjediste = listaSjedista.FirstOrDefault(x => x.SjedisteID == ulaznica.SjedisteID);
                if (odabranoSjediste != null)
                {
                    odabranoSjediste.Zauzeto = true;
                }
            }
            model.brojRedova = Convert.ToInt32(listaSjedista.Max(x => x.OznakaReda));
            model.brojKolona = Convert.ToInt32(listaSjedista.Max(x => x.OznakaReda));
            model.projekcija = projekcija;
            model.sjedista = listaSjedista;

            return PartialView("_sjedistaGrid", model);
        }
    }
}
