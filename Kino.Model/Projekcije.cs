using System;
using System.Collections.Generic;
using System.Text;

namespace Kino.Model
{
    public class Projekcije
    {
        public int ProjekcijaID { get; set; }
        public DateTime Datum { get; set; }
        public decimal Cijena { get; set; }
        public string Sala { get; set; }
        public int SalaID { get; set; }
        public string Film { get; set; }
        public int FilmID { get; set; }


    }
}
