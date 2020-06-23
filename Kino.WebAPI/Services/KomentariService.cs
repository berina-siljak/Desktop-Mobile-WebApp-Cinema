using AutoMapper;
using Kino.Model.Requests;
using Kino.WebAPI.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebAPI.Services
{
    public class KomentariService : BaseCRUDService<Model.Komentari, KomentariSearchRequest, Database.Komentari, KomentariInsertRequest, KomentariInsertRequest>
    {
        public KomentariService(KinoContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Komentari> Get(KomentariSearchRequest search)
        {
            var q = _context.Set<Database.Komentari>().Include(x => x.Kupac).AsQueryable();

            if (search?.FilmID.HasValue == true)
            {
                q = q.Where(s => s.FilmID == search.FilmID);
            }

            var list = q.ToList();
            return _mapper.Map<List<Model.Komentari>>(list);
        }
    }
}