using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.Model.Requests
{
   public class ProizvodiSearchRequest
    {
        //public int ProizvodId { get; set; }
        public int? KategorijaId { get; set; }
        public string Naziv { get; set; }
    }
}
