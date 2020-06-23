using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kino.Model
{
    public class KorisniciUloge
    {
        [Key]
        public int KorisnikUlogaID { get; set; }
        [ForeignKey("UlogaID")]
        public Uloge Uloga { get; set; }
        public int UlogaID { get; set; }
        [ForeignKey("KorisnikID")]
        public Korisnici Korisnik { get; set; }
        public int KorisnikID { get; set; }

        public DateTime DatumIzmjene { get; set; }
    }
}
