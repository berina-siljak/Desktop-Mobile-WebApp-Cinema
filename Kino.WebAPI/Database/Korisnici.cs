using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebAPI.Database
{
    public class Korisnici
    {
        public Korisnici()
        { 
            KorisniciUloge = new HashSet<KorisniciUloge>();
        }

        [Key]
        public int KorisnikID { get; set; }
      
        public string Ime { get; set; }
       
        public string Prezime { get; set; }
     
        public string Email { get; set; }
      
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
      
        public bool? IsActive { get; set; }
        
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }

        public virtual ICollection<KorisniciUloge> KorisniciUloge { get; set; }


    }
}
