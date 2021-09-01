using eRestoran.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Mobile.Models
{
    public class NarudzbaItem
    {
        public Proizvodi Proizvod { get; set; }
        public double Cijena { get; set; }
        public decimal Kolicina { get; set; }
    }
}
