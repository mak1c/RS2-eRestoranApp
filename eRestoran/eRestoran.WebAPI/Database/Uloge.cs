using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Database
{
    public partial class Uloge
    {

        //public Uloge()
        //{
        //    KorisniciUloge = new HashSet<KorisniciUloge>();
        //}
        [Key]
        public int UlogaId { get; set; }
        public string Naziv { get; set; }
       

        //public ICollection<KorisniciUloge> KorisniciUloge { get; set; }
    }
}

