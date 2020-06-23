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
    public class SjedistaService : ISjedistaService
    {
        private readonly KinoContext _context;
        private readonly IMapper _mapper;
        public SjedistaService(KinoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Sjedista> Get(Model.Requests.SjedistaSearchRequest search)
        {
            var q = _context.Set<Database.Sjedista>().Include(x => x.Sala).AsQueryable();
            if (search.SalaID != null && search?.SalaID !=0)
            {
                q = q.Where(s => s.SalaID == search.SalaID);
            }
          
            var list = q.ToList();
            return _mapper.Map<List<Model.Sjedista>>(list);
        }

        public List<Model.Sjedista> Insert(SjedistaInsertRequest request)
        {
            var entity = _mapper.Map<List<Database.Sjedista>>(request.sjedista);
            foreach (var item in entity)
            {
                _context.Add(item);
                _context.SaveChanges();

            }
            return _mapper.Map<List<Model.Sjedista>>(request.sjedista);
        }


    }
}
