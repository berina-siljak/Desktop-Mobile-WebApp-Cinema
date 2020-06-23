using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Kino.Model
{
    public class Korisnici
    {
        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
      
        public bool? IsActive { get; set; }
        public ICollection<KorisniciUloge> KorisniciUloge { get; set; }
    }
}
