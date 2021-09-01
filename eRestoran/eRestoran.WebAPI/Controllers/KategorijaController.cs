using eRestoran.Model;
using eRestoran.Model.Requests;
using eRestoran.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Controllers
{

    public class KategorijaController : BaseCRUDController<Model.Kategorija, KategorijaSearchRequest, KategorijaUpsertRequest, KategorijaUpsertRequest>
    {
        public KategorijaController(ICRUDService<Kategorija, KategorijaSearchRequest, KategorijaUpsertRequest, KategorijaUpsertRequest> service) : base(service)
        {
        }
        
    }
}
