using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kino.Model.Requests;
using Kino.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kino.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SjedistaController : ControllerBase
    {
        private readonly ISjedistaService _service;
        public SjedistaController(ISjedistaService service)
        {
            _service = service;
        }
        //public SjedistaController(ICRUDService<Model.Sjedista, SjedistaSearchRequest,SjedistaInsertRequest,SjedistaInsertRequest> service) : base(service)
        //{

        // }
        [HttpGet]
        public List<Model.Sjedista> Get([FromQuery]SjedistaSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpPost]
        public List<Model.Sjedista> Insert(SjedistaInsertRequest request)
        {
            return _service.Insert(request);
        }

    }
}