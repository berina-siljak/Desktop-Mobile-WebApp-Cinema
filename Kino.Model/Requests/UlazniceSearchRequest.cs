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
    }
}
