using System;
using System.Collections.Generic;
using System.Text;

namespace Kino.Model.Requests
{
    public class OcjeneInsertRequest
    {
        public int Ocjena { get; set; }
        public int KupacID { get; set; }
        public int FilmID { get; set; }
    }
}
