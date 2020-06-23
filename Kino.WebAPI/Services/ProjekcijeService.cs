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
    public class ProjekcijeService: BaseCRUDService<Projekcije, ProjekcijeSearchRequest, Database.Projekcije, ProjekcijeInsertRequest, ProjekcijeInsertRequest>
    {
        
        public ProjekcijeService(KinoContext context, IMapper mapper) : base(context, mapper)
        {
        }


        public override List<Projekcije> Get(ProjekcijeSearchRequest search)
        {
            var q = _context.Set<Database.Projekcije>().AsQueryable();
            if (!search.sveProjekcije)
                q = q.Where(s => s.Datum.Date >= DateTime.Now.Date);

            if (search?.FilmID.HasValue == true)
            {
                q = q.Where(s => s.FilmID == search.FilmID);
            }
            var list = q.ToList();
            return _mapper.Map<List<Projekcije>>(list);

        }



    }
}
