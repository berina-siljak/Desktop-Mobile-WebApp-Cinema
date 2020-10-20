using System;
using System.Collections.Generic;
using System.Text;

namespace Kino.Model.Requests
{

    public class ProjekcijeSearchRequest
    {
        public int? FilmID { get; set; }
        public bool sveProjekcije { get; set; }

        public int? SalaID { get; set; }


        public DateTime? DatumOd{ get; set; }
        public DateTime? DatumDo { get; set; }

        public DateTime? Datum { get; set; }

        public int Max { get; set; }

        public int ?zanrid { get; set; }

    }
}
