using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebApp.Models
{
    public class IzvjestajViewModel
    {
        public int BrojFilmova { get; set; }
        public int BrojProjekcija { get; set; }
        public int BrojUlaznica { get; set; }
        public int BrojKupaca { get; set; }

        public List<TopFilmViewModel> TopFilmovi {get; set;}
        public IzvjestajViewModel()
        {
            TopFilmovi = new List<TopFilmViewModel>();
        }
  


    }
}
