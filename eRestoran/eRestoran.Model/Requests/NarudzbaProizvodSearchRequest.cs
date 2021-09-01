using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.Model.Requests
{
    public class NarudzbaProizvodSearchRequest
    {
        public int? NarudzbaId { get; set; }
        public int ProizvodId { get; set; }
    }
}
