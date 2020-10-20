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
        public DateTime DatumProjekcije { get; set; }
        public string Projekcija { get; set; }
        public int? KupacID { get; set; }
        public string Kupac { get; set; }
        public string Sala { get; set; }
        public decimal CijenaSaPopustom { get; set; }
        public int Popust { get; set; }
        public DateTime Datum { get; set; }
     
        public byte[] BarCodeImg { get; set; }

    }
    public class UlazniceProvjera
    {
        public int UlaznicaID { get; set; }
        public string poruka { get; set; }
        public bool isValid { get; set; }

        public UlazniceProvjera()
        {

        }
        public UlazniceProvjera(Ulaznice model)
        {
            UlaznicaID = model.UlaznicaID;
            if (model.DatumProjekcije >= DateTime.Now)
            {
                poruka = "Ulaznica je validna!";
                isValid = true;
            }
            else
            {
                poruka = "Ulaznica nije validna!";
                isValid = false;
            }
        }
    }
}
