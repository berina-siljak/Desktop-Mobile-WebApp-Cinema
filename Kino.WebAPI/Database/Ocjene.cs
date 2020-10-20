using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebAPI.Database
{
    public class Ocjene
    {
        [Key]
        public int OcjenaID { get; set; }
        public int Ocjena { get; set; }
        [ForeignKey("KupacID")]
        public int KupacID { get; set; }
        [ForeignKey("FilmID")]
        public int FilmID { get; set; }
        public Kupci Kupac { get; set; }
        public Filmovi Filmovi { get; set; }
    }
}
