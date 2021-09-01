using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.Model.Requests
{
    public class OcjenaInsertRequest
    {
        public int OcjenaId { get; set; }
        public int ProizvodId { get; set; }
        public int KorisnikId { get; set; }
        public int OcjenaKorisnika { get; set; }
        public DateTime DatumOcjenjivanja { get; set; }
    }
}
