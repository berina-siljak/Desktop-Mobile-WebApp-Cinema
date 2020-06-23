using System;
using System.Collections.Generic;
using System.Text;

namespace Kino.Model
{
    public class Kupci
    {
        public int KupacID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public string Password { get; set; }

        public string Telefon { get; set; }
        public int BrojTokena { get; set; }
        public string ImePrezimeKupca { get { return Ime + " " + Prezime; } }


    }
}
