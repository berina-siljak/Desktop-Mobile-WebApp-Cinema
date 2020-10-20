using Kino.Model.Requests;
using Kino.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebApp.Controllers
{
    public class KupciController : Controller
    {
        APIService _service = new APIService("Kupci");

        KupciInsertRequest request = new KupciInsertRequest();
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var model = (await _service.Get<List<Model.Kupci>>(null)).Select(x => new KupciViewModel(x)).ToList();
            return View("Kupci", model);
        }

        public async Task<IActionResult> Detalji()
        {
            await _service.Get<List<Model.Kupci>>(null);
            return View("KupciDetalji");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var model = new KupciViewModel(await _service.GetById<Model.Kupci>(id));
            return View("KupciDetalji", model);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var model = new KupciViewModel(await _service.Delete<Model.Kupci>(id));
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Snimi(KupciViewModel model)
        {
            //ModelState.Remove("KupacID");

            if (ModelState.IsValid)
            {
                request.Ime = model.Ime;
                request.Prezime = model.Prezime;
                request.KorisnickoIme = model.KorisnickoIme;
                request.Telefon = model.Telefon;
                request.Email = model.Email;
                request.Password = model.Password;
                request.PasswordPotvrda = model.PasswordConfirmation;


                if (model.KupacID != null)
                {
                    try
                    {
                        await _service.Update<Model.Kupci>(model.KupacID.Value, request);
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
                        await _service.Insert<Model.Kupci>(request);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                return RedirectToAction("Index");
            }
            return View("KupciDetalji");

        }
    }
}
