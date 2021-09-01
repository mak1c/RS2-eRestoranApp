using AutoMapper;
using eRestoran.Model.Requests;
using eRestoran.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Services
{
    public class OcjeneService : BaseCRUDService<Model.Ocjena, OcjenaSearchRequest, Database.Ocjena, OcjenaInsertRequest, OcjenaInsertRequest>
    {
        public OcjeneService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
