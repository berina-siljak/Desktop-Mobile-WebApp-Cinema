using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kino.Model.Requests;
using Kino.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kino.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KupciController : ControllerBase
    {
        private readonly IKupciService _service;

        public KupciController(IKupciService service)
        {
            _service = service;
        }

        [HttpGet]
        [Authorize]
        public List<Model.Kupci> Get([FromQuery]KupciSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.Kupci Insert(KupciInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.Kupci Update(int id, [FromBody]KupciInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Kupci GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpDelete("{id}")]
        public Model.Kupci Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
