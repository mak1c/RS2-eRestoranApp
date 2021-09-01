using eRestoran.Model;
using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Services
{
   public interface INarudzbeService
    {
        List<Narudzbe> Get();
        Narudzbe GetById(int id);

        Model.Narudzbe Update(int id, NarudzbaUpsertRequest request);
        Model.Narudzbe Insert(int id, NarudzbaUpsertRequest request);
    }
}
