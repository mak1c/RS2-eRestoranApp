using AutoMapper;
using eRestoran.Model.Requests;
using eRestoran.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Services
{
    public interface IKorisniciService
    {
        List<Model.Korisnici> Get(KorisniciSearchRequest request);

        Model.Korisnici GetById(int id);

        Model.Korisnici Insert(KorisniciInsertRequest request);

        Model.Korisnici Update(int id, KorisniciUpdateRequest request);

        Model.Korisnici Authenticiraj(string username, string pass);
    }
}
