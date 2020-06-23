using AutoMapper;
using Kino.WebAPI.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kino.Model.Requests;
using Kino.Model;

namespace Kino.WebAPI.Services
{
    public class FilmoviService : BaseCRUDService<Filmovi, FilmoviSearchRequest, Database.Filmovi, FilmoviInsertRequest, FilmoviInsertRequest>
    {
        private readonly KinoContext _context;
        private readonly IMapper _mapper;
        public FilmoviService(KinoContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public override List<Filmovi> Get(FilmoviSearchRequest search)
        {
            var q = _context.Set<Database.Filmovi>().AsQueryable();

            if (!string.IsNullOrEmpty(search?.Zanr) && search?.ZanrID.HasValue == true)
            {
                q = q.Where(s => s.Naziv.Equals(search.Zanr) && s.ZanrID == search.ZanrID);
            }

            if (!string.IsNullOrEmpty(search?.Naziv))
            {
                q = q.Where(x => x.Naziv.ToLower().StartsWith(search.Naziv.ToLower()));
            }
            if (search?.ZanrID.HasValue == true)
            {
                q = q.Where(s => s.Zanr.ZanrID == search.ZanrID);
            }

            var list = q.ToList();
            return _mapper.Map<List<Filmovi>>(list);
        }
    }

}
