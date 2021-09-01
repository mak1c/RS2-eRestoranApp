using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.Model.Requests
{
    public class NarudzbaProizvodUpsertRequest
    {
        public int Kolicina { get; set; }
        public double Cijena { get; set; }
        public int NarudzbeId { get; set; }
        public string Narudzba { get; set; }
        public string Proizvod { get; set; }
        public int ProizvodId { get; set; }

    }
}