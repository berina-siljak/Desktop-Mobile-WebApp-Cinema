using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kino.Model.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Kino.WebApp.Models;
namespace Kino.WebApp.Controllers
{
    public class KorisniciController : Controller
    {
        APIService _service = new APIService("Korisnici");

        KorisniciInsertRequest request = new KorisniciInsertRequest();
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var model = (await _service.Get<List<Model.Korisnici>>(null)).Select(x => new KorisniciViewModel(x)).ToList();
            return View("Korisnici", model);
        }

        public async Task<IActionResult> Detalji()
        {
            //await _service.Get<List<Model.Korisnici>>(null);
            KorisniciViewModel model = new KorisniciViewModel();
            return View("KorisniciDetalji",model);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var model = new KorisniciViewModel(await _service.GetById<Model.Korisnici>(id));
            return View("KorisniciDetalji", model);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var model = new KorisniciViewModel(await _service.Delete<Model.Korisnici>(id));
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Snimi(KorisniciViewModel model)
        {
            //ModelState.Remove("KorisnikID");
            if (ModelState.IsValid)
            {
                request.Ime = model.Ime;
                request.Prezime = model.Prezime;
                request.KorisnickoIme = model.KorisnickoIme;
                request.Telefon = model.Telefon;
                request.Email = model.Email;
                request.Password = model.Password;
                request.PasswordConfirmation = model.PasswordConfirmation;

                if (model.KorisnikID != null)
                {
                    try
                    {
                        await _service.Update<Model.Korisnici>(model.KorisnikID.Value, request);
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
                        await _service.Insert<Model.Korisnici>(request);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                return RedirectToAction("Index");
            }
            return View("KorisniciDetalji");
        }
    }
}