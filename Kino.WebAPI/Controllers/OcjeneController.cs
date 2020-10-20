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
    public class OcjeneController : BaseCRUDController<Model.Ocjene,OcjeneSearchRequest, OcjeneInsertRequest, OcjeneInsertRequest>
    {
        public OcjeneController(ICRUDService<Model.Ocjene, OcjeneSearchRequest,OcjeneInsertRequest, OcjeneInsertRequest> service) : base(service)
        {
        }
    }
}