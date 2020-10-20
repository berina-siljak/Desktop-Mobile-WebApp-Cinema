using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kino.Model;
using Kino.Model.Requests;
using Kino.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kino.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UlazniceController : ControllerBase
    {
        private readonly IUlazniceService _service;
        public UlazniceController(IUlazniceService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Ulaznice> Get([FromQuery]UlazniceSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Ulaznice Insert(UlazniceInsertRequest request)
        {
            var baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";

            return _service.Insert(request, baseUrl);
        }
        [HttpDelete("{id}")]
        public Model.Ulaznice Delete(int id)
        {
            return _service.Delete(id);
        }
        [HttpGet("Provjera")]
        public UlazniceProvjera Provjera(int id)
        {
            return new UlazniceProvjera(_service.ProvjeraUlaznice(id));
        }
        [HttpGet("{id}")]
        public Model.Ulaznice GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPut("{id}")]
        public Model.Ulaznice Update(int id, [FromBody]UlazniceInsertRequest request)
        {
            return _service.Update(id, request);
        }
    }
}