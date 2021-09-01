using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.Model.Requests
{
 
    public class KategorijaUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Opis { get; set; }
        //[Range(0, double.MaxValue)]

        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        //public bool? Status { get; set; }
    }
}
