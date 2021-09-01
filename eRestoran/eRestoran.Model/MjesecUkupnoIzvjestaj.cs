using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class MjesecUkupnoIzvjestaj
    {
        public int MjesecBroj { get; set; }
        public string MjesecNaziv { get; set; }
        public int MjesecBrojProdatih { get; set; }
        public decimal MjesecUkupno { get; set; }
    }
}
