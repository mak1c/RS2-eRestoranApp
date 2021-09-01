using eRestoran.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Services
{
    interface IKategorijaService
    {
        List<Kategorija> Get();
        Kategorija GetById(int id);
        int Prebroj();
    }
}
