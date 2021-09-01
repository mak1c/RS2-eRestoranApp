using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.Model.Requests
{
    public class NarudzbaUpsertRequest
    {
        //public int NarudzbaId { get; set; }
        public DateTime DatumNarudžbe { get; set; }
        //public bool Prihvacena { get; set; }
        //public bool Zavrsena { get; set; }
        public int NarudzbaStatusId { get; set; }
        public int KorisnikId { get; set; }
        public string BrojTelefona { get; set; }
        public string Adresa { get; set; }
        public string PaymentId { get; set; }
        public bool Placena { get; set; }

        public decimal ZaUplatiti { get; set; }
    }
}
