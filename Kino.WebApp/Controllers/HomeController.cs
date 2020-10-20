using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kino.WebApp.Models;
using Kino.Model;

namespace Kino.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly APIService _service = new APIService("Korisnici");
        private readonly APIService _serviceUlaznice = new APIService("Ulaznice");
        private readonly APIService _serviceKupci = new APIService("Kupci");
        private readonly APIService _serviceFilmovi = new APIService("Filmovi");
        private readonly APIService _serviceProjekcije = new APIService("Projekcije");


        public async Task<IActionResult> Index()
        {
            var modelUlaznice = (await _serviceUlaznice.Get<List<Model.Ulaznice>>(null)).Select(x => new UlazniceViewModel(x)).ToList();
            var modelKupci = (await _serviceKupci.Get<List<Model.Kupci>>(null)).Select(x => new KupciViewModel(x)).ToList();
            var modelFilmovi = (await _serviceFilmovi.Get<List<Model.Filmovi>>(null)).Select(x => new FilmoviViewModel(x)).ToList();
            var modelProjekcije = (await _serviceProjekcije.Get<List<Model.Projekcije>>(null)).Select(x => new ProjekcijeViewModel(x)).ToList();
            var model = new IzvjestajViewModel();
            model.BrojFilmova = modelFilmovi.Count();
            model.BrojKupaca = modelKupci.Count();
            model.BrojUlaznica = modelUlaznice.Count();
            model.BrojProjekcija = modelProjekcije.Count();
            foreach (var item in modelFilmovi)
            {
                var topfilm = new TopFilmViewModel();
                topfilm.brojProdaja = modelUlaznice.Count(x => x.Projekcija.ToLower() == item.Naziv.ToLower());
                topfilm.naziv = item.Naziv;
                topfilm.sirina = (float)(topfilm.brojProdaja / 50.0 * 100.0);
                model.TopFilmovi.Add(topfilm);
            }
            model.TopFilmovi = model.TopFilmovi.OrderByDescending(x => x.brojProdaja).Take(5).ToList();
            return View(model);
        }


        public async Task<JsonResult> My_Chart()
        {
            var modelUlaznice = (await _serviceUlaznice.Get<List<Model.Ulaznice>>(null)).Select(x => new UlazniceViewModel(x)).ToList();
            var recordData = new List<DiagramData>();
            var months = new List<string>() { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            for (int i = 1; i < 13; i++) //for each month
            {
                var tempData = new DiagramData();
                tempData.labels = months[i - 1];
                tempData.data = modelUlaznice.Count(x => x.Datum.Month == i);
                recordData.Add(tempData);
            }
            return Json(recordData);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Izvjestaj()
        {

            return View();
        }
        public async Task<IActionResult> Authorize(LoginViewModel model)
        {
            APIService.Username = model.username;
            APIService.Password = model.password;

            try
            {
                await _service.Get<dynamic>(null);
                Korisnici korisnik = null;
                List<Korisnici> lista = await _service.Get<List<Korisnici>>(null);
                korisnik = lista.FirstOrDefault(x => x.KorisnickoIme == model.username);
                if (korisnik != null)
                {
                    APIService.KorisnikID = korisnik.KorisnikID;
                    return RedirectToAction("Index");
                }
                else
                {
                    //Greska
                    return View("_login");
                }

            }
            catch (Exception ex)
            {
            }
            return View("_login");
            //return View("Index");
        }

        public IActionResult Login()
        {
            return View("_login");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
