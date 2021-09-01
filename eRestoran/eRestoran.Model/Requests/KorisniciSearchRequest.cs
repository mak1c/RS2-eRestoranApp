using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.Model.Requests
{
   public class KorisniciSearchRequest
    {
        public int? Id { get; set; }
        public string Ime { get; set; }

        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string Uloga { get; set; }
        public int UlogaId { get; set; }
        public bool StatusPretraga { get; set; }
        public bool Status { get; set; }
        //public bool IsUlogeLoadingEnabled { get; set; }
    }
}
