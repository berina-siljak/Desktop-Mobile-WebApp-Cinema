using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Kino.Model
{
    public class Ulaznice
    {
        public int UlaznicaID { get; set; }
        public int SjedisteID { get; set; }
        public string OznakaSjedista { get; set; }
        public int ProjekcijaID { get; set; }
        public string Projekcija { get; set; }
        public int? KupacID { get; set; }
        public string Kupac { get; set; }
        public string Sala { get; set; }
        public decimal CijenaSaPopustom { get; set; }
        public int Popust { get; set; }
        public DateTime Datum { get; set; }
     
        public byte[] BarCodeImg { get; set; }



    }
}
