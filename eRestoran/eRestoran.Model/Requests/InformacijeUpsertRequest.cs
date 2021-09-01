using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.Model.Requests
{
   public class InformacijeUpsertRequest
    {
        public string BrojTelefona { get; set; }
        public string Lokacija { get; set; }
        public string NazivObjekta { get; set; }

        public DateTime RadimoOd { get; set; }

        public DateTime RadimoDo { get; set; }

         public byte[] Slika { get; set; }
       
    }
}
