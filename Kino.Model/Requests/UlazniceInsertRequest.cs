using System;
using System.Collections.Generic;
using System.Text;

namespace Kino.Model.Requests
{
    public class UlazniceInsertRequest
    {

        public int SjedisteID { get; set; }
        public int ProjekcijaID { get; set; }
        public int? KupacID { get; set; }
        public DateTime Datum { get; set; }
        public int Popust { get; set; }
        public decimal CijenaSaPopustom { get; set; }

        public byte[] BarCodeImg { get; set; }

    }
}
