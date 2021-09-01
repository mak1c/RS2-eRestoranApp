using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.Model
{
    public class NarudzbaProizvod
    {
        public int NarudzbaProizvodId { get; set; }
        public int Kolicina { get; set; }
        public double Cijena { get; set; }
        public double Ukupno { get; set; }
        public int NarudzbaId { get; set; }
        public int ProizvodId { get; set; }
        public string Proizvod { get; set; }
    }
}
