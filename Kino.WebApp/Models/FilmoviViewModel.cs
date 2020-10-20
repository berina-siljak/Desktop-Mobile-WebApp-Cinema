using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Kino.Model;
using System.ComponentModel.DataAnnotations;

namespace Kino.WebApp.Models
{
    public class FilmoviViewModel
    {
        public int? FilmID { get; set; }
        [Required(ErrorMessage = "Unesite naziv filma!")]
        public string Naziv { get; set; }
        [Required(ErrorMessage = "Unesite opis filma!")]

        public string Opis { get; set; }
        [Required(ErrorMessage = "Unesite ime režisera!")]

        public string Reziser { get; set; }
        [Required(ErrorMessage = "Unesite glumce!")]

        public string Glumci { get; set; }
        [RegularExpression(@"[0-4]{4}", ErrorMessage = "Godina mora sadržavati 4 cifre.")]
        [Required(ErrorMessage = "Unesite godinu!")]

        public string GodinaIzdavanja { get; set; }

        [Required(ErrorMessage = "Unesite trajanje filma!")]
        public int? Trajanje { get; set; }

        public IFormFile Slika { get; set; }
        public string SlikaUrl { get; set; }
        public int ZanrID { get; set; }
        public string NazivZanra { get; set; }

        public string VideoUrl { get; set; }

        public FilmoviViewModel()
        {

        }

        public FilmoviViewModel(Filmovi model)
        {
            FilmID = model.FilmID;
            Naziv = model.Naziv;
            Opis = model.Opis;
            Reziser = model.Reziser;
            Glumci = model.Glumci;
            GodinaIzdavanja = model.GodinaIzdavanja;
            Trajanje = model.Trajanje;
            if(model.Slika != null)
            SlikaUrl = "data:image/jpeg;base64," + Convert.ToBase64String(model.Slika);
            ZanrID = model.ZanrId;
            NazivZanra = model.NazivZanra;
            VideoUrl = model.VideoUrl;
        }
    }
}
