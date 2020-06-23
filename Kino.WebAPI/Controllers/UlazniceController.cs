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
    public class UlazniceController : BaseCRUDController<Model.Ulaznice, UlazniceSearchRequest, UlazniceInsertRequest, UlazniceInsertRequest>
    {
        public UlazniceController(ICRUDService<Ulaznice, UlazniceSearchRequest, UlazniceInsertRequest, UlazniceInsertRequest> service) : base(service)
        {
        }
    }
}