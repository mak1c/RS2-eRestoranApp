using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.Model.Requests
{
    public class ProizvodiUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }
        [Required]
        [Range(0, double.MaxValue)]
        public int VrijemePripremanja { get; set; }
        [Range(0, double.MaxValue)]
        public decimal Cijena { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Opis { get; set; }
        public int KategorijaId { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
    }
}
