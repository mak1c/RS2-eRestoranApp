using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.Model.Requests
{
    public class KorisniciUpdateRequest
    {
        //[Required(AllowEmptyStrings = false)]
        public string Ime { get; set; }
        //[Required(AllowEmptyStrings = false)]
        public string Prezime { get; set; }
        //[EmailAddress]
        //[Required]
        //[MinLength(4)]
        public string Email { get; set; }
        //[Required(AllowEmptyStrings = false)]
        public string Telefon { get; set; }
        //[Required(AllowEmptyStrings = false)]
        public string KorisnickoIme { get; set; }
        public string Password { get; set; }
        public string PasswordPotvrda { get; set; }
        public bool Status { get; set; }
        public byte[] Slika { get; set; }
        public int UlogaId { get; set; }

    }
}



