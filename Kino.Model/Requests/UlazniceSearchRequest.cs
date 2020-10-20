using System;
using System.Collections.Generic;
using System.Text;

namespace Kino.Model.Requests
{
    public class UlazniceSearchRequest
    {
        public int? KupacID { get; set; }
        public int? Godina { get; set; }
        public int? ProjekcijaID { get; set; }
        public int? SjedisteID { get; set; }
        public string ImeKupca { get; set; }

        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }

       

    }
}
