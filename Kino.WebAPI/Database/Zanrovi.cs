using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebAPI.Database
{
    public class Zanrovi
    {
        [Key]
        public int ZanrID { get; set; }
        public string Naziv { get; set; }
    }
}
