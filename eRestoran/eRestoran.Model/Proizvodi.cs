using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.Model
{
    public class Proizvodi
    {
        public int ProizvodId { get; set; }
        public string Naziv { get; set; }
        public int VrijemePripremanja { get; set; }
        public string Opis { get; set; }
        public decimal Cijena { get; set; }
        
        public int KategorijaId { get; set; }
        public Kategorija Kategorija { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }

        public decimal AveragePrice { get; set; }


    }
}
