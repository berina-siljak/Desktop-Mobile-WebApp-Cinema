using System;
using System.Collections.Generic;
using System.Text;

namespace Kino.Model.Requests
{
    public class FilmoviInsertRequest
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Reziser { get; set; }
        public string Glumci { get; set; }
        public string GodinaIzdavanja { get; set; }
        public int Trajanje { get; set; }
        public byte[] Slika { get; set; }
        public Zanrovi Zanr { get; set; }
        public int ZanrID { get; set; }
        public string VideoUrl { get; set; }
    }
}

