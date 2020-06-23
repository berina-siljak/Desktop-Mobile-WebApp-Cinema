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
    public class SaleService : BaseCRUDService<Sale, SaleSearchRequest, Database.Sale, SaleInsertRequest, SaleInsertRequest>
    {
      
        public SaleService(KinoContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Sale> Get(SaleSearchRequest search)
        {
            var query = _context.Sale.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.ToLower().StartsWith(search.Naziv) || x.Naziv.ToUpper().StartsWith(search.Naziv));
            }

            var list = query.ToList();
            return _mapper.Map<List<Model.Sale>>(list);
        }


    }
}
