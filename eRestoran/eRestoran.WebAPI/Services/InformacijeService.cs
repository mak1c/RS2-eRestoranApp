using AutoMapper;
using eRestoran.WebAPI.Database;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Services
{
    public class InformacijeService : BaseCRUDService<Model.Informacije, Model.Requests.InformacijeSearchRequest, Database.Informacije, Model.Requests.InformacijeUpsertRequest, Model.Requests.InformacijeUpsertRequest>
    {
        public InformacijeService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }



        [AllowAnonymous]
        public override Model.Informacije GetById(int id)
        {
            var entity = _context.Informacije.Find(id);

            return _mapper.Map<Model.Informacije>(entity);
        }

    }
}
