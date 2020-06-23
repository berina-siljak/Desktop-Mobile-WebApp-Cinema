using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebAPI.Database
{
    public class Filmovi
    {
        [Key]
        public int FilmID { get; set; }
        [ForeignKey("ZanrID")]
        public Zanrovi Zanr { get; set; }
        public int ZanrID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Reziser { get; set; }
        public string Glumci { get; set; }
        public string GodinaIzdavanja { get; set; }
        public int Trajanje { get; set; }
        public byte[] Slika { get; set; }

    }
}
