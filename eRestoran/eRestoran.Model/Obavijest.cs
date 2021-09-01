using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
   public class Obavijest
    {
        public int ObavijestId { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }

        public DateTime DatumObjave { get; set; }
    }
}
