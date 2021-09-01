using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRestoran.Model;
using eRestoran.Model.Requests;
using eRestoran.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eRestoran.WebAPI.Controllers
{
    [Microsoft.AspNetCore.Authorization.AllowAnonymous]
    public class InformacijeController : BaseCRUDController<Model.Informacije, InformacijeSearchRequest, InformacijeUpsertRequest, InformacijeUpsertRequest>
    {
        public InformacijeController(ICRUDService<Model.Informacije, InformacijeSearchRequest, InformacijeUpsertRequest, InformacijeUpsertRequest> service) : base(service)
        {
        }
    }
}