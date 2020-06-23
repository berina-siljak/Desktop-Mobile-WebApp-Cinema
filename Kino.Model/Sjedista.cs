using System;
using System.Collections.Generic;
using System.Text;

namespace Kino.Model
{
    public class Sjedista
    {
        public int SjedisteID { get; set; }
        
        public string OznakaReda { get; set; }
        public string OznakaKolone { get; set; }
        public string OznakaSjedista { get; set; }
        public bool Zauzeto { get; set; }
        public string Sala { get; set; }
        public int SalaID { get; set; }

    }
}
