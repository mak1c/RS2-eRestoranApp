using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRestoran.Model.Requests;
using eRestoran.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eRestoran.WebAPI.Controllers
{
    public class OcjenaController : BaseCRUDController<Model.Ocjena, OcjenaSearchRequest, OcjenaInsertRequest, OcjenaInsertRequest>
    {
        public OcjenaController(ICRUDService<Model.Ocjena, OcjenaSearchRequest, OcjenaInsertRequest, OcjenaInsertRequest> service) : base(service)
        {
        }
    }
}