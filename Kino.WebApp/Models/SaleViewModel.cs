using Kino.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebApp.Models
{
    public class SaleViewModel
    {
        public int? SalaID { get; set; }
        [Required(ErrorMessage = "Unesite naziv sale!")]

        public string Naziv { get; set; }
        [Required(ErrorMessage = "Unesite broj redova!")]

        public string BrojRedova { get; set; }
        [Required(ErrorMessage = "Unesite broj kolona!")]


        public string BrojKolona { get; set; }

        public SaleViewModel()
        {

        }

        public SaleViewModel(Sale model)
        {
            SalaID = model.SalaID;
            Naziv = model.Naziv;
            BrojKolona = model.BrojKolona;
            BrojRedova = model.BrojRedova;

        }
    }
}
