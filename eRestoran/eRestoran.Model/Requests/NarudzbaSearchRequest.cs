using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.Model.Requests
{
    public class NarudzbeSearchRequest
    {
        public int NarudzbeId { get; set; }
        public DateTime DatumNarudzbe { get; set; }
        //public bool Prihvacena { get; set; }
        public bool DatumPretraga { get; set; }
        public int NarudzbaStatusId { get; set; }
        public int KorisnikId { get; set; }

        
    }
}
