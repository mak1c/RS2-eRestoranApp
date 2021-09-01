using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Database
{
    public partial class NarudzbaProizvod
    {
        public int NarudzbaProizvodId { get; set; }
        public int Kolicina { get; set; }
        public double Cijena { get; set; }
        public int NarudzbaId { get; set; }
        public int ProizvodId { get; set; }

        public virtual Proizvodi Proizvod { get; set; }
        public virtual Narudzbe Narudzba { get; set; }
    }
}
