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
    public class FilmoviController : BaseCRUDController<Filmovi, FilmoviSearchRequest, FilmoviInsertRequest, FilmoviInsertRequest>
    {
        public FilmoviController(ICRUDService<Filmovi, FilmoviSearchRequest, FilmoviInsertRequest, FilmoviInsertRequest> service) : base(service)
        {
        }
  
    }
}