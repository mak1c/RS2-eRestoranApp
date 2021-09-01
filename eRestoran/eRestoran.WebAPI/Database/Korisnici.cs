using eRestoran.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Database
{
 
      
    
   
    public partial class Korisnici
    {
    
        [Key]
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public bool Status { get; set; }
        public int UlogaId { get; set; }
        public Uloge Uloga { get; set; }
        public byte[] Slika { get; set; }
       
    }

}