using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Kino.WebAPI.Services;
using System.Collections.Generic;

namespace ePozoriste.WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PreporukeController : ControllerBase
    {
        private readonly IPreporukeService _service;

        public PreporukeController(IPreporukeService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public List<Kino.Model.Filmovi> Get(int id)
        {
            return _service.GetPreporuka(id);
        }
    }

}