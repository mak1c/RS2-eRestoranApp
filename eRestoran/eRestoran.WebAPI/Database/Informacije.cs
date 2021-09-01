using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Database
{
    public partial class Informacije
    {
        public int Id { get; set; }
        public string BrojTelefona { get; set; }
        public string Lokacija { get; set; }
        public string NazivObjekta { get; set; }
        [DataType(DataType.Time)]
        public DateTime RadimoOd { get; set; }
        [DataType(DataType.Time)]
        public DateTime RadimoDo { get; set; }

        public byte[] Slika { get; set; }
    }
}
