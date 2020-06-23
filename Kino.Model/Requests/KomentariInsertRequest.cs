using System;
using System.Collections.Generic;
using System.Text;

namespace Kino.Model.Requests
{
    public class KomentariInsertRequest
    {
        public string Sadrzaj { get; set; }
        public DateTime VrijemeKreiranja { get; set; }
        public int KupacID { get; set; }
        public int FilmID { get; set; }
    }
}
