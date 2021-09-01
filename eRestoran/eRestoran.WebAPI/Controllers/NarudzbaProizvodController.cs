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
    public class NarudzbaProizvodController : BaseCRUDController<Model.NarudzbaProizvod, NarudzbaProizvodSearchRequest, NarudzbaProizvodUpsertRequest, NarudzbaProizvodUpsertRequest>
    {
        public NarudzbaProizvodController(ICRUDService<Model.NarudzbaProizvod, NarudzbaProizvodSearchRequest, NarudzbaProizvodUpsertRequest, NarudzbaProizvodUpsertRequest> service) : base(service)
        {
        }
    }
}