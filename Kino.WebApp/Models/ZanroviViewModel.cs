using Kino.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebApp.Models
{
    public class ZanroviViewModel
    {
        public int? ZanrID { get; set; }
        [Required(ErrorMessage = "Unesite žanr!")]
        [RegularExpression("[A-Z][a-zA-Z]+", ErrorMessage = "Naziv žanra može sadržavati samo slova!")]
        public string Naziv { get; set; }

        public ZanroviViewModel()
        {

        }

        public ZanroviViewModel(Zanrovi model)
        {
            ZanrID = model.ZanrID;
            Naziv = model.Naziv;
 
        }
    }
}
