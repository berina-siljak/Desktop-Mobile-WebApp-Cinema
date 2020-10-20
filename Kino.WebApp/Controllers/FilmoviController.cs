using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kino.Model;
using Kino.Model.Requests;
using Microsoft.AspNetCore.Mvc.Rendering;
using Kino.WebApp.Models;
using System.Drawing;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Text;

namespace Kino.WebApp.Controllers
{
    public class FilmoviController : Controller
    {
        APIService _service = new APIService("Filmovi");
        APIService _zanroviservice = new APIService("Zanrovi");
        FilmoviInsertRequest request = new FilmoviInsertRequest();
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var model = (await _service.Get<List<Model.Filmovi>>(null)).Select(x => new FilmoviViewModel(x)).ToList();
            return View("Filmovi", model);
        }

        public async Task<IActionResult> Detalji()
        {
            ViewBag.Zanrovi = new SelectList(await _zanroviservice.Get<List<Model.Zanrovi>>(null), "ZanrID", "Naziv");
            return View("FilmoviDetalji");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var model = new FilmoviViewModel(await _service.GetById<Model.Filmovi>(id));
            ViewBag.Zanrovi = new SelectList(await _zanroviservice.Get<List<Model.Zanrovi>>(null), "ZanrID", "Naziv");

            //Passing image data in viewbag to view  
            string imgDataURL = string.Format("data:image/png;base64,{0}", model.SlikaUrl);
            ViewBag.ImageData = imgDataURL;
            return View("FilmoviDetalji", model);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var model = new FilmoviViewModel(await _service.Delete<Model.Filmovi>(id));
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Snimi(FilmoviViewModel model)
        {
            //ModelState.Remove("FilmID");
            if (ModelState.IsValid)
            {
                request.ZanrID = model.ZanrID;
                request.Naziv = model.Naziv;
                request.Opis = model.Opis;
                request.Reziser = model.Reziser;
                request.Trajanje = model.Trajanje !=null? model.Trajanje.Value:0;
                request.Glumci = model.Glumci;
                request.GodinaIzdavanja = model.GodinaIzdavanja;
                request.VideoUrl = model.VideoUrl;
                if (model.ZanrID != 0)
                    request.ZanrID = model.ZanrID;
                if (model.Slika != null)
                    request.Slika = IFormFileToByte(model.Slika);
                if (model.FilmID != null)
                {
                    try
                    {
                        await _service.Update<Model.Filmovi>(model.FilmID.Value, request);
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
                        await _service.Insert<Model.Filmovi>(request);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                return RedirectToAction("Index");
            }
            ViewBag.Zanrovi = new SelectList(await _zanroviservice.Get<List<Model.Zanrovi>>(null), "ZanrID", "Naziv");
            return View("FilmoviDetalji");

        }

        public byte[] IFormFileToByte(IFormFile file)
        {
            if (file.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    // act on the Base64 data
                    return fileBytes;
                }
            }
            return null;
        }

    }
}
