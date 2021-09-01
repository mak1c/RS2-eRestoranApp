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
    public class ProizvodiController : BaseCRUDController<Model.Proizvodi, ProizvodiSearchRequest, ProizvodiUpsertRequest, ProizvodiUpsertRequest>
    {
        public ProizvodiController(ICRUDService<Proizvodi, ProizvodiSearchRequest, ProizvodiUpsertRequest, ProizvodiUpsertRequest> service) : base(service)
        {
        }

    }
}