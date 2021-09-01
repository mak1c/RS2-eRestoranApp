using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.Model.Requests
{
    public class ObavijestSearchRequest
    {
        public int? Id { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }

    }
}
