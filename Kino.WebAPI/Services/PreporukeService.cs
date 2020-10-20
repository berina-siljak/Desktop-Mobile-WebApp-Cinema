using AutoMapper;
using Kino.WebAPI.Database;
using Kino.WebAPI.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebAPI.Services
{
    public class PreporukeService : IPreporukeService
    {
        private readonly KinoContext _context;
        private readonly IMapper _mapper;
        public int BrojPreporuka = 5;
        public PreporukeService(KinoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Filmovi> GetPreporuka(int KupacId)
        {
            List<Ulaznice> MojeUlaznice = _context.Ulaznice.Where(x => x.KupacID == KupacId)
                .Include(x => x.Projekcija.Film.Zanr)
                .ToList();


            if (MojeUlaznice.Count() > 0)
            {
                List<Zanrovi> sviZanrovi = new List<Zanrovi>();
                foreach (var ulaznica in MojeUlaznice)
                {
                    var prjekcijaZanr = ulaznica.Projekcija.Film.Zanr;

                    bool add = true;
                    for (int i = 0; i < sviZanrovi.Count; i++)
                    {
                        if (prjekcijaZanr.ZanrID == sviZanrovi[i].ZanrID)
                        {
                            add = false;
                        }
                    }

                    if (add)
                    {
                        sviZanrovi.Add(prjekcijaZanr);
                    }
                }

                List<Filmovi> ListaPreporucenihFilmova = new List<Filmovi>();
                foreach (var Zanr in sviZanrovi)
                {
                    var FilmoviTogZanra = _context.Filmovi
                        .Where(x => x.ZanrID == Zanr.ZanrID)
                        .ToList();

                    foreach (var film in FilmoviTogZanra)
                    {
                        bool add = true;
                        for (int i = 0; i < ListaPreporucenihFilmova.Count; i++)
                        {
                            if (film.FilmID == ListaPreporucenihFilmova[i].FilmID)
                            {
                                add = false;
                            }
                        }

                        foreach (var ulaznica in MojeUlaznice)
                        {
                            if (film.FilmID == ulaznica.Projekcija.FilmID)
                            {
                                add = false;
                            }
                        }

                        if (add)
                        {
                            ListaPreporucenihFilmova.Add(film);
                        }
                    }
                }

                ListaPreporucenihFilmova = ListaPreporucenihFilmova.OrderBy(x => Guid.NewGuid()).Take(BrojPreporuka).ToList();

                if (ListaPreporucenihFilmova.Count == 0)
                {
                    ListaPreporucenihFilmova = _context.Filmovi.Take(BrojPreporuka).OrderBy(x => Guid.NewGuid()).ToList();
                }

                var list2 = _mapper.Map<List<Model.Filmovi>>(ListaPreporucenihFilmova);
     
                return list2;

            }

            var ListaSvihFilmova = _context.Filmovi.Take(BrojPreporuka).OrderBy(x => Guid.NewGuid()).ToList();
            var list1 = _mapper.Map<List<Model.Filmovi>>(ListaSvihFilmova);



            return list1;

        }
    }
}
