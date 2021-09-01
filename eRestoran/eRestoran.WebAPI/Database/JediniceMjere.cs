using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Database
{
    public partial class JediniceMjere
    {
        [Key]
        public int JediniceMjereId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
    }
}
