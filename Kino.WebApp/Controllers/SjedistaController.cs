using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kino.Model.Requests;
using Kino.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kino.WebApp.Controllers
{
    public class SjedistaController : Controller
    {
        APIService _saleService = new APIService("Sale");
        APIService _sjedistaService = new APIService("Sjedista");
        SjedistaInsertRequest request = new SjedistaInsertRequest();
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var model = (await _sjedistaService.Get<List<Model.Sjedista>>(null)).Select(x => new SjedistaViewModel(x)).ToList();
            return View("Sjedista", model);
        }

        public async Task<IActionResult> Detalji()
        {
            ViewBag.Sale = new SelectList(await _saleService.Get<List<Model.Sale>>(null), "SalaID", "Naziv");
            return View("SjedistaDetalji");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var model = new SjedistaViewModel(await _sjedistaService.GetById<Model.Sjedista>(id));
            ViewBag.Sale = new SelectList(await _saleService.Get<List<Model.Sale>>(null), "SalaID", "Naziv");
            return View("SjedistaDetalji", model);


        }
        public async Task<IActionResult> Delete(int id)
        {
            var model = new SjedistaViewModel(await _sjedistaService.Delete<Model.Sjedista>(id));
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Snimi(SjedistaViewModel model)
        {
            if (ModelState.IsValid)
            {
                request.SalaID = model.SalaID;
                if (model.SjedisteID != null)
                {
                    try
                    {
                        await _sjedistaService.Update<Model.Sjedista>(model.SjedisteID.Value, request);
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
                        await _sjedistaService.Insert<Model.Sjedista>(request);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                return View("Sjedista");
            }
            return View("SjedistaDetalji");

        }



    }
}