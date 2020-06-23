using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebAPI.Database
{
    public class KorisniciUloge
    {
        [Key]
        public int KorisnikUlogaID { get; set; }
        [ForeignKey("UlogaID")]
        public virtual Uloge Uloga { get; set; }
        public int UlogaID { get; set; }
        [ForeignKey("KorisnikID")]
        public virtual Korisnici Korisnik { get; set; }
        public int KorisnikID { get; set; }

        public DateTime DatumIzmjene { get; set; }
    }
}
