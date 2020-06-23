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
    public class ZanroviController : BaseCRUDController<Model.Zanrovi, Model.Requests.ZanroviSearchRequest, ZanroviInsertRequest, ZanroviInsertRequest>
    {

        public ZanroviController(ICRUDService<Model.Zanrovi, ZanroviSearchRequest, ZanroviInsertRequest, ZanroviInsertRequest> service) : base(service)
        {
        }
    }
}