using System;
using System.Collections.Generic;
using System.Text;

namespace Kino.Model.Requests
{
    public class ProjekcijeInsertRequest
    {
        public DateTime Datum { get; set; }
        public decimal Cijena { get; set; }
        public int SalaID { get; set; }
        public int FilmID { get; set; }

        public int KorisnikID { get; set; }
    }
}
