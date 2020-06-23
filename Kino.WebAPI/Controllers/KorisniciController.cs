using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Kino.Model.Requests;
using Kino.WebAPI.Database;
using Kino.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Kino.WebAPI.Controllers
{
    //ovaj tag ispod
    [Authorize]
    //govori da pozivi u ovom kontroleru trebaju biti logirani, naprotiv vraca 401
    //ako to nema, pozivi su otvoreni za izvrsavanje
    [Route("api/[controller]")]
        [ApiController]
        public class KorisniciController : ControllerBase
        {
            private readonly IKorisniciService _service;
            public KorisniciController(IKorisniciService service)
            {
                _service = service;
            }

       
        [HttpGet]
        public List<Model.Korisnici> Get([FromQuery]KorisniciSearchRequest request)
        {
                 return _service.Get(request);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPut("{id}")]
        public Model.Korisnici Update(int id, [FromBody]KorisniciInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Korisnici GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost("login")]
        public Model.Korisnici Login(KorisniciLoginRequest request)
        {
            return _service.Login(request);
        }
    }

}
