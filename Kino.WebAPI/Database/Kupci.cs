using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebAPI.Database
{
    public class Kupci
    {
        [Key]
        public int KupacID { get; set; }
        [RegularExpression(@"^[a-zA-Z ]+$")]
        public string Ime { get; set; }
        [RegularExpression(@"^[a-zA-Z -]+$")]
        public string Prezime { get; set; }

        public string Email { get; set; }
        [RegularExpression(@"^(?=.{6,40}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$")]
        public string Telefon { get; set; }
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?")]
        public string KorisnickoIme { get; set; }
        //public DateTime CreateDate { get; set; }

        public bool IsActive { get; set; }
        //public string Code { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public int BrojTokena { get; set; }

    }
}
