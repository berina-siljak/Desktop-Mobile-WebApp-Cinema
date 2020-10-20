using AutoMapper;
using Kino.Model;
using Kino.Model.Requests;
using Kino.WebAPI.EF;
using Microsoft.EntityFrameworkCore;
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
            var q = _context.Set<Database.Projekcije>().Include(x => x.Film).Include(x=>x.Sala).AsQueryable();
            
            //prikazuje sve projekcije od trenutnog datuma
            if (!search.sveProjekcije)
                q = q.Where(s => s.Datum.Date >= DateTime.Now.Date);

            if (search?.zanrid.HasValue == true)
            {
                q = q.Where(s => s.Film.ZanrID == search.zanrid);
            }
            if (search?.SalaID.HasValue == true)
            {
                q = q.Where(s => s.Sala.SalaID == search.SalaID);
            }


            if (search?.FilmID.HasValue == true)
            {
                q = q.Where(s => s.FilmID == search.FilmID);
            }
            //odvojeno
            //if (search?.DatumOd.HasValue == true && search?.DatumDo.HasValue == true)
            //{
            //    q = q.Where(s => s.Datum >= search.DatumOd && s.Datum <= search.DatumDo);
            //}
            if (search?.Datum.HasValue == true)
            {
                q = q.Where(s => s.Datum.Date == search.Datum.Value.Date);
            }


            var list = q.ToList();
            return _mapper.Map<List<Projekcije>>(list);

        }

    }
}
