using AutoMapper;
using Kino.Model;
using Kino.Model.Requests;
using Kino.WebAPI.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebAPI.Services
{
        public class ZanroviService : BaseCRUDService<Model.Zanrovi, ZanroviSearchRequest, Database.Zanrovi, ZanroviInsertRequest, ZanroviInsertRequest>
    {

        public ZanroviService(KinoContext context, IMapper mapper) : base(context, mapper)
        {
        }    

        public override List<Model.Zanrovi> Get(ZanroviSearchRequest search)
        {
            var query = _context.Zanrovi.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.ToLower().StartsWith(search.Naziv.ToLower()));
            }

            var list = query.ToList();
            return _mapper.Map<List<Model.Zanrovi>>(list);
        }
    }
}

