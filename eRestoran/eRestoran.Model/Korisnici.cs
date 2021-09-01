using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.Model
{
  
    public class Korisnici
    {

        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public bool Status { get; set; }
        public byte[] Slika { get; set; }

        public int UlogaId { get; set; }

        //public ICollection<KorisniciUloge> KorisniciUloge { get; set; }
    }
}
