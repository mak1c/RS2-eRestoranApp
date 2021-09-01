using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Mobile.Models
{
    public class NarudzbeA
    {
        public int NarudzbeId { get; set; }
        public DateTime DatumNarudžbe { get; set; }
        //public bool Prihvacena { get; set; }
        //public bool Zavrsena { get; set; }
        public string NarudzbaStatus { get; set; }
        public string BojaStatusa { get; set; }
        public int KorisnikId { get; set; }

        public string BrojTelefona { get; set; }
        public string Adresa { get; set; }

        public string Korisnik { get; set; }
        public bool PlacenaBool { get; set; }
        public string Placena { get; set; }

        public decimal ZaUplatit { get; set; }



    }
}
