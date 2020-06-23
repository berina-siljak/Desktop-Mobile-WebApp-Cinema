using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebAPI.Database
{
    public class Sjedista
    {
        [Key]
        public int SjedisteID { get; set; }
        public int OznakaReda { get; set; }
        public int OznakaKolone { get; set; }
        //public bool Rezervisano { get; set; }
        [ForeignKey("SalaID")]
        public Sale Sala { get; set; }
        public int SalaID { get; set; }

    }
}
