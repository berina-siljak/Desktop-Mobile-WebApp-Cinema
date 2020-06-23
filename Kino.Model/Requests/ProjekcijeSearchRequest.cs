using System;
using System.Collections.Generic;
using System.Text;

namespace Kino.Model.Requests
{

    public class ProjekcijeSearchRequest
    {
        //public int? SalaID { get; set; }
        public int? FilmID { get; set; }
        public bool sveProjekcije { get; set; }
    }
}
