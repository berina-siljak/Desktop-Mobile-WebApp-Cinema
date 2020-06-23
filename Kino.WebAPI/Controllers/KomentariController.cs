using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kino.Model;
using Kino.Model.Requests;
using Kino.WebAPI.Database;
using Kino.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kino.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KomentariController : BaseCRUDController<Model.Komentari, KomentariSearchRequest, KomentariInsertRequest, KomentariInsertRequest>
    {
        public KomentariController(ICRUDService<Model.Komentari, KomentariSearchRequest, KomentariInsertRequest, KomentariInsertRequest> service) : base(service)
        {
        }
    }
}