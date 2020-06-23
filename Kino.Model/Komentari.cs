using System;
using System.Collections.Generic;
using System.Text;

namespace Kino.Model
{
    public class Komentari
    {
        public int KomentarID { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime VrijemeKreiranja { get; set; }
        public int KupacID { get; set; }
        public string KorisnickoIme { get; set; }
        public int FilmID { get; set; }
    }
}
