using System;
using System.Collections.Generic;
using System.Text;

namespace Kino.Model
{
    public class Izvjestaj
    {
        public string Film { get; set; }
        public string Zanr { get; set; }
        public int BrojProdanihUlaznica { get; set; }
        public decimal Zarada { get; set; }
    }
}
