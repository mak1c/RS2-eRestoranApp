using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRestoran.Model;
using eRestoran.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eRestoran.WebAPI.Controllers
{
     public class UlogeController : BaseController<Model.Uloge, object>
    {
        public UlogeController(IService<Uloge, object> service) : base(service)
        {
        }
    }
}