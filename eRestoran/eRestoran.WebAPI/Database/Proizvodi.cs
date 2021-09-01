using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Database
{
    public partial class Proizvodi
    {


        [Key]
        public int ProizvodId { get; set; }
        public string Naziv { get; set; }
        public int VrijemePripremanja { get; set; }
        public string Opis { get; set; }
        public decimal Cijena { get; set; }

        public int KategorijaId { get; set; }
        public Kategorija Kategorija { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }



       
    }
}
