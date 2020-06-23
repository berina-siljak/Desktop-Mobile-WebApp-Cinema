using System;
using System.Collections.Generic;
using System.Text;

namespace Kino.Model.Requests
{
    public class FilmoviSearchRequest
    {
        public int? ZanrID { get; set; }
        public string Zanr { get; set; }
        public string Naziv { get; set; }

    }
}
