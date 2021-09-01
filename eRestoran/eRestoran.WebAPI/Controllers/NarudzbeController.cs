using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRestoran.Model.Requests;
using eRestoran.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using eRestoran.Model;
using Microsoft.AspNetCore.Mvc;

namespace eRestoran.WebAPI.Controllers
{
    public class NarudzbeController : BaseCRUDController<Model.Narudzbe, Model.Requests.NarudzbeSearchRequest, Model.Requests.NarudzbaUpsertRequest, Model.Requests.NarudzbaUpsertRequest>
    {
        public NarudzbeController(ICRUDService<Model.Narudzbe, NarudzbeSearchRequest, NarudzbaUpsertRequest, NarudzbaUpsertRequest> service) : base(service)
        {
        }


    }
}