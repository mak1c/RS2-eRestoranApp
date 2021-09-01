using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Database
{
    public partial class Narudzbe
    {
        public int NarudzbeId { get; set; }
        public DateTime DatumNarudžbe { get; set; }
        //public bool Prihvacena { get; set; }
        //public bool Zavrsena { get; set; }
        public int NarudzbaStatusId { get; set; }
        public NarudzbaStatus NarudzbaStatus { get; set; }
        public int KorisnikId { get; set; }
        public string BrojTelefona { get; set; }
        public string Adresa { get; set; }

        public string PaymentId { get; set; }
        public virtual Korisnici Korisnik { get; set; }
        public bool Placena { get; set; }
        public decimal ZaUplatiti { get; set; }
    }
}
