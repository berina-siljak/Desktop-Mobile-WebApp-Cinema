using Kino.Model.Requests;
using Kino.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebApp.Controllers
{
    public class ProjekcijeController : Controller
    {
        //APIService _korisnikService = new APIService("Korisnici");
        APIService _filmoviService = new APIService("Filmovi");
        APIService _saleService = new APIService("Sale");
        APIService _projekcijeService = new APIService("Projekcije");

        ProjekcijeInsertRequest request = new ProjekcijeInsertRequest();


        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var model = (await _projekcijeService.Get<List<Model.Projekcije>>(null)).Select(x => new ProjekcijeViewModel(x)).ToList();
            return View("Projekcije", model);
        }

        public async Task<IActionResult> Detalji()
        {
            ViewBag.Filmovi = new SelectList(await _filmoviService.Get<List<Model.Filmovi>>(null), "FilmID", "Naziv");
            ViewBag.Sale = new SelectList(await _saleService.Get<List<Model.Sale>>(null), "SalaID", "Naziv");

            return View("ProjekcijeDetalji");
        }
        public async Task<IActionResult> Delete(int id)
        {
            var model = new ProjekcijeViewModel(await _projekcijeService.Delete<Model.Projekcije>(id));
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int id)
        {
            var model = new ProjekcijeViewModel(await _projekcijeService.GetById<Model.Projekcije>(id));
            ViewBag.Sale = new SelectList(await _saleService.Get<List<Model.Sale>>(null), "SalaID", "Naziv");
            ViewBag.Filmovi = new SelectList(await _filmoviService.Get<List<Model.Filmovi>>(null), "FilmID", "Naziv");
            return View("ProjekcijeDetalji", model);
        }
        public async Task<IActionResult> Snimi(ProjekcijeViewModel model)
        {
            request.SalaID = model.SalaID;
            request.FilmID = model.FilmID;
            request.KorisnikID = APIService.KorisnikID;
            request.Cijena = model.Cijena;
            request.Datum = model.Datum.Date + model.Vrijeme.TimeOfDay;
          
         
            if (model.ProjekcijaID != null)
            {
                try
                {
                    await _projekcijeService.Update<Model.Projekcije>(model.ProjekcijaID.Value, request);
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
                    await _projekcijeService.Insert<Model.Projekcije>(request);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
          
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<JsonResult> GetProjekcijeByFilmId(int id)
        {
            try
            {
                var result = new SelectList(await _projekcijeService.Get<List<Model.Projekcije>>(new ProjekcijeSearchRequest()
                {
                    FilmID = id,
                    sveProjekcije = true
                }), "ProjekcijaID", "Datum");
                return Json(result);
            }
            catch (Exception)
            {
                ViewBag.Message = "Fethcing sublocation failed";
                return Json("Fethcing sublocation failed");
                throw;
            }
        }

    }
}
