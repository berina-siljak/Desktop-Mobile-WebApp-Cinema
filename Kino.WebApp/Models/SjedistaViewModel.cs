using Kino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebApp.Models
{
    public class SjedistaViewModel
    {
        public int? SjedisteID { get; set; }
        public string OznakaReda { get; set; }
        public string OznakaKolone { get; set; }
        public bool Zauzeto { get; set; }

        public string Sala { get; set; }
        public int SalaID { get; set; }

        public SjedistaViewModel()
        {

        }

        public SjedistaViewModel(Sjedista model)
        {
            SalaID = model.SalaID;
            OznakaReda = model.OznakaReda;
            OznakaKolone = model.OznakaKolone;
            Sala = model.Sala;
            SjedisteID = model.SjedisteID;
        }
    }
}
