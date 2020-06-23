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
    public class ProjekcijeController : BaseCRUDController<Model.Projekcije, ProjekcijeSearchRequest, ProjekcijeInsertRequest, ProjekcijeInsertRequest>
    {
        public ProjekcijeController(ICRUDService<Model.Projekcije, ProjekcijeSearchRequest, ProjekcijeInsertRequest, ProjekcijeInsertRequest> service) : base(service)
        {
        }

    }
}