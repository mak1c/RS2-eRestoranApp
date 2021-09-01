using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRestoran.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eRestoran.WebAPI.Controllers
{
    public class NarudzbaStatusController : BaseController<Model.NarudzbaStatus, object>
    {
        public NarudzbaStatusController(IService<Model.NarudzbaStatus, object> service) : base(service)
        {
        }


    }
}