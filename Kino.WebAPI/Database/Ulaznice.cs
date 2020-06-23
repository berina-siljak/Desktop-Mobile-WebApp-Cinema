using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebAPI.Database
{
    public class Ulaznice
    {
        [Key]
        public int UlaznicaID { get; set; }
        public DateTime Datum { get; set; }
        [ForeignKey("SjedisteID")]
        public Sjedista Sjediste { get; set; }
        public int SjedisteID { get; set; }
        [ForeignKey("ProjekcijaID")]
        public Projekcije Projekcija { get; set; }
        public int ProjekcijaID { get; set; }
        [ForeignKey("KupacID")]
        public Kupci Kupac { get; set; }
        public int? KupacID { get; set; }
        public byte[] BarCodeIMG { get; set; }
        public decimal CijenaSaPopustom { get; set; }
        public int Popust { get; set; }


    }
}
