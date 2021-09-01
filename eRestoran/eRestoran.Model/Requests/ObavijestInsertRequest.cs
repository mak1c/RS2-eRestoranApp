using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eRestoran.Model.Requests
{
    public class ObavijestInsertRequest
    {
        [Required]
        [MinLength(4)]
        public string Naslov { get; set; }
        [Required]
        [MinLength(10)]
        public string Sadrzaj { get; set; }

        public DateTime DatumObjave { get; set; }

    }
}

