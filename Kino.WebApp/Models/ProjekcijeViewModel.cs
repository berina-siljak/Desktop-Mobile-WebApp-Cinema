using Kino.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebApp.Models
{
    public class ProjekcijeViewModel
    {
        public int? ProjekcijaID { get; set; }
        [Required(ErrorMessage = "Molimo unesite datum!")]
        public DateTime Datum { get; set; }
        public DateTime Vrijeme { get; set; }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public decimal Cijena { get; set; }
        public int SalaID { get; set; }
        public string NazivSale { get; set; }
        public int FilmID { get; set; }
        public string NazivFilma { get; set; }
        public int KorisnikID { get; set; }
        public string ImePrezimeKorisnika { get; set; }

        public ProjekcijeViewModel()
        {

        }

        public ProjekcijeViewModel(Projekcije model)
        {
            ProjekcijaID = model.ProjekcijaID;
            Datum = model.Datum;
            Vrijeme = model.Datum;
            SalaID = model.SalaID;
            NazivSale = model.Sala;
            FilmID = model.FilmID;
            NazivFilma = model.Film;
            Cijena = model.Cijena;
        }
    }
    public class ProjekcijeSjedistaViewModel
    {
        public int brojRedova { get; set; }
        public int brojKolona { get; set; }
        public ProjekcijeViewModel projekcija { get; set; }
        public List<SjedistaViewModel> sjedista { get; set; }
        public ProjekcijeSjedistaViewModel()
        {

        }
    }
}

