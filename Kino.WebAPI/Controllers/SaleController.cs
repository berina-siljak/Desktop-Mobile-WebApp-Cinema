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
    public class SaleController : BaseCRUDController<Sale, SaleSearchRequest, SaleInsertRequest, SaleInsertRequest>
    {
        public SaleController(ICRUDService<Sale, SaleSearchRequest, SaleInsertRequest, SaleInsertRequest> service) : base(service)
        {
        }

    }

}