using System;
using System.Collections.Generic;
using System.Text;

namespace Kino.Model
{
    public class Sale
    {
        public int SalaID { get; set; }
        public string Naziv { get; set; }
        //duzina i sirina
        public string BrojRedova { get; set; }
        public string BrojKolona { get; set; }
    }
}
