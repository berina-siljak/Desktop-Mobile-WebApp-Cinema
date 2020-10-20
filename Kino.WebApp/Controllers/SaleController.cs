using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kino.Model.Requests;
using Kino.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kino.WebApp.Controllers
{
    public class SaleController : Controller
    {
        APIService _saleService = new APIService("Sale");
        APIService _sjedistaService = new APIService("Sjedista");

        SaleInsertRequest request = new SaleInsertRequest();
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var model = (await _saleService.Get<List<Model.Sale>>(null)).Select(x => new SaleViewModel(x)).ToList();
            return View("Sale", model);
        }

        public async Task<IActionResult> Detalji()
        {
            await _saleService.Get<List<Model.Sale>>(null);
            return View("SaleDetalji");
        }

        public async Task<IActionResult> Edit(int id)
        {

            var model = new SaleViewModel(await _saleService.GetById<Model.Sale>(id));
            return View("SaleDetalji", model);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var model = new SaleViewModel(await _saleService.Delete<Model.Sale>(id));
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Snimi(SaleViewModel model)
        {
            //ModelState.Remove("SalaID");
            if (ModelState.IsValid)
            {
                request.BrojRedova = model.BrojRedova;
                request.BrojKolona = model.BrojKolona;
                request.Naziv = model.Naziv;
                if (model.SalaID != null)
                {
                    await _saleService.Update<Model.Sale>(model.SalaID.Value, request);
                }
                else
                {
                    var sala = await _saleService.Insert<Model.Sale>(request);
                    var sjedista = new SjedistaInsertRequest();
                    sjedista.sjedista = new List<Model.Sjedista>();

                    //popunjavanje sjedista kad se unese broj redova i broj kolona sale!
                    for (int i = 1; i <= Convert.ToInt32(request.BrojRedova); i++)
                    {
                        for (int j = 1; j <= Convert.ToInt32(request.BrojKolona); j++)
                        {
                            var sjediste = new Model.Sjedista();
                            sjediste.SalaID = sala.SalaID;
                            sjediste.OznakaReda = i.ToString();
                            sjediste.OznakaKolone = j.ToString();
                            sjedista.sjedista.Add(sjediste);
                        }

                    }
                    await _sjedistaService.Insert<List<Model.Sjedista>>(sjedista);
                }

                return RedirectToAction("Index");
            }
            return View("SaleDetalji");


            //return View("Zanrovi");
        }

    }
}