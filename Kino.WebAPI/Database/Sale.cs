using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebAPI.Database
{
    public class Sale
    {
        [Key]
        public int SalaID { get; set; }
        public string Naziv { get; set; }
        //duzina i sirina
        public string BrojRedova { get; set; }
        public string BrojKolona { get; set; }
        
    }
}
