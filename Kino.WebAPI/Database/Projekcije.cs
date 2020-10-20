using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebAPI.Database
{
    public class Projekcije
    {
        [Key]
        public int ProjekcijaID { get; set; }
        public DateTime Datum { get; set; }
        public decimal Cijena { get; set; }
        [ForeignKey("KorisnikID")]
        public Korisnici Korisnik { get; set; }
        public int KorisnikID { get; set; }
        [ForeignKey("SalaID")]
        public Sale Sala { get; set; }
        public int SalaID { get; set; }
        [ForeignKey("FilmID")]
        public Filmovi Film { get; set; }
        public int FilmID { get; set; }

    }
}
