using System;
using System.Collections.Generic;
using System.Text;

namespace Kino.Model.Requests
{
    public class SjedistaInsertRequest
    {
        public int SalaID { get; set; }
        public List<Model.Sjedista> sjedista { get; set; }
    }
}
