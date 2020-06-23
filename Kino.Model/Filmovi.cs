using System;
using System.Collections.Generic;
using System.Text;

namespace Kino.Model
{
    public class Filmovi
    {
        public int FilmID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Reziser { get; set; }
        public string Glumci { get; set; }
        public string GodinaIzdavanja { get; set; }
        public int Trajanje { get; set; }
     
        public byte[] Slika { get; set; }
        public int ZanrId { get; set; }
        public string NazivZanra { get; set; }

    }
}
