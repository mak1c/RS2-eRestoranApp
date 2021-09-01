
using eRestoran.Model;
using eRestoran.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Controllers
{

    public class JediniceMjereController : BaseController<Model.JediniceMjere, object>
    {
        public JediniceMjereController(IService<JediniceMjere, object> service) : base(service)
        {
        }


    }
}
