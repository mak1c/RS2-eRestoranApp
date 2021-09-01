using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Database
{
    public partial class NarudzbaStatus
    {
        [Key]
        public int NarudzbaStatusId { get; set; }
        public string Status { get; set; }
    }
}
