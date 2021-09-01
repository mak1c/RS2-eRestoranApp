using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Database
{
    public class Ocjena
    {
        public int OcjenaId { get; set; }
        public int ProizvodId { get; set; }
        public int KorisnikId { get; set; }
        public int OcjenaKorisnika { get; set; }

        public DateTime DatumOcjenjivanja { get; set; }
    }
}
