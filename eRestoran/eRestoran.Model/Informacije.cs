using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.Model
{
    public class Informacije
    {
        public int Id { get; set; }
        public string BrojTelefona { get; set; }
        public string Lokacija { get; set; }
        public string NazivObjekta { get; set; }
        public DateTime RadimoOd { get; set; }
        public DateTime RadimoDo { get; set; }
        public byte[] Slika { get; set; }


    }
}
