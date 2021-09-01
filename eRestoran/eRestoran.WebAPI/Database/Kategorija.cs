using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Database
{
    public partial class Kategorija
    {
        public Kategorija()
        {
            Proizvodi = new HashSet<Proizvodi>();
        }
        [Key]
        public int KategorijaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }

        public ICollection<Proizvodi> Proizvodi { get; set; }

    }
}


