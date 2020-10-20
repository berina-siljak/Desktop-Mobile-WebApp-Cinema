using System;
using System.Collections.Generic;
using System.Text;

namespace Kino.Model
{
    public class NoviModel
    {
        public int KupacID { get; set; }
        public string Kupac { get; set; }
        public string Projekcija { get; set; }
        //treba
        public int ProjekcijaID { get; set; }
        public decimal Uplata { get; set; }

    }
}
