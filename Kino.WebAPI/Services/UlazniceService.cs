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
    public class UlazniceService : BaseCRUDService<Model.Ulaznice, Model.Requests.UlazniceSearchRequest, Database.Ulaznice, UlazniceInsertRequest, UlazniceInsertRequest>
    {

        public UlazniceService(KinoContext context, IMapper mapper) : base(context, mapper)
        {
            //_context = context;
            //_mapper = mapper;

        }
        public override List<Ulaznice> Get(UlazniceSearchRequest search)
        {
            var q = _context.Set<Database.Ulaznice>().Include(x => x.Sjediste).Include(x => x.Projekcija.Film).Include(x => x.Projekcija.Sala).AsQueryable();

            if (search?.KupacID.HasValue == true)
            {
                q = q.Where(s => s.Kupac.KupacID == search.KupacID);
            }

            if (search?.ProjekcijaID.HasValue == true)
            {
                q = q.Where(s => s.ProjekcijaID == search.ProjekcijaID);
            }
            if (search?.Godina.HasValue == true)
            {
                q = q.Where(s => s.Datum.Year == search.Godina);
            }

            var list = q.ToList().OrderByDescending(s => s.Datum);
            return _mapper.Map<List<Ulaznice>>(list);

        }
       
    }
}
