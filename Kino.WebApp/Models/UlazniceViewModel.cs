using Kino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebApp.Models
{
    public class UlazniceViewModel
    {
        public int? UlaznicaID { get; set; }
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
        public DateTime Vrijeme { get; set; }


        public UlazniceViewModel()
        {

        }

        public UlazniceViewModel(Ulaznice model)
        {
            UlaznicaID = model.UlaznicaID;
            SjedisteID = model.SjedisteID;
            OznakaSjedista = model.OznakaSjedista;
            ProjekcijaID = model.ProjekcijaID;
            Projekcija = model.Projekcija;
            KupacID = model.KupacID;
            Kupac = model.Kupac;
            Sala = model.Sala;
            CijenaSaPopustom = model.CijenaSaPopustom;
            Popust = model.Popust;
            Datum = model.Datum;
            Vrijeme = model.Datum;

        }
    }
    public class DiagramData
    {
        public int data { get; set; }
        public string labels { get; set; }
    }

    public class TopFilmViewModel
    {
        public string naziv { get; set; }
        public int brojProdaja { get; set; }
        public float sirina { get; set; }
    }
}
