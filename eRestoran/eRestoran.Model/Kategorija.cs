﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.Model
{
    public class Kategorija
    {
        public int KategorijaId { get; set; }
        public string Naziv { get; set; }

        public string Opis { get; set; }

        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
    }
}
