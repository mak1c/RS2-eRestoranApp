using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.Model.Requests
{
    public class KorisniciInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-zA-ZČčĆćŽžĐđŠš ]+$", ErrorMessage = "Dozvoljena su samo slova!")]
        [StringLength(50, ErrorMessage = "Maksimalna dozvoljena duzina je 50 karaktera!")]
        public string Ime { get; set; }
        [Required(AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-zA-ZČčĆćŽžĐđŠš ]+$", ErrorMessage = "Dozvoljena su samo slova!")]
        [StringLength(50, ErrorMessage = "Maksimalna dozvoljena duzina je 50 karaktera!")]
        public string Prezime { get; set; }
        [EmailAddress]
        [Required]
        [MinLength(5)]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false)]
        [RegularExpression(@"^[0-9]+$")]
        public string Telefon { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string KorisnickoIme { get; set; }
        //[Required(AllowEmptyStrings = false)]
        //[MinLength(4)]
        public string Password { get; set; }
        //[Required(AllowEmptyStrings = false)]
        public string PasswordPotvrda { get; set; }
        public bool Status { get; set; }
        public byte[] Slika { get; set; }
        public int UlogaId { get; set; }

        //public List<int> Uloge { get; set; } = new List<int>();
    }
}



