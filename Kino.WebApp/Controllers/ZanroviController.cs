using Kino.Model.Requests;
using Kino.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebApp.Controllers
{
    public class ZanroviController : Controller
    {
        APIService _zanroviservice = new APIService("Zanrovi");
        ZanroviInsertRequest request = new ZanroviInsertRequest();
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var model = (await _zanroviservice.Get<List<Model.Zanrovi>>(null)).Select(x => new ZanroviViewModel(x)).ToList();
            return View("Zanrovi", model);
        }

        public async Task<IActionResult> Detalji()
        {
            await _zanroviservice.Get<List<Model.Zanrovi>>(null);
            return View("ZanroviDetalji");
        }

        public async Task<IActionResult> Edit(int id)
        {

            var model = new ZanroviViewModel(await _zanroviservice.GetById<Model.Zanrovi>(id));
            return View("ZanroviDetalji", model);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var model = new ZanroviViewModel(await _zanroviservice.Delete<Model.Zanrovi>(id));
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Snimi(ZanroviViewModel model)
        {

            //ModelState.Remove("ZanrID");
            if (ModelState.IsValid && ModelState["ZanrID"].Errors.Count >= 0)
            {
                request.Naziv = model.Naziv;

                if (model.ZanrID != null)
                {
                    try
                    {
                        await _zanroviservice.Update<Model.Zanrovi>(model.ZanrID.Value, request);
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
                        await _zanroviservice.Insert<Model.Zanrovi>(request);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                return RedirectToAction("Index");
            }
            return View("ZanroviDetalji", model);


            //return View("Zanrovi");
        }

    }
}


