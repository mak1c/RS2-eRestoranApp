using eRestoran.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Services
{
    interface IProizvodiService
    {
        List<Proizvodi> Get();
        Proizvodi GetById(int id);
        //int Prebroj();
    }
}
