using eRestoran.Model.Requests;
using eRestoran.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Controllers
{
   [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _service;
        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }
        [Authorize]
        [HttpGet]
        public List<Model.Korisnici> Get([FromQuery]KorisniciSearchRequest request)
        {
            return _service.Get(request);
        }


        [Authorize]
        [HttpPut("{id}")]
        public Model.Korisnici Update(int id, [FromBody]KorisniciUpdateRequest request)
        {
            return _service.Update(id, request);
        }
        [Authorize]
        [HttpGet("{id}")]
        public Model.Korisnici GetById(int id)
        {
            return _service.GetById(id);
        }
        //[Authorize(Roles = "Administrator")]
        [AllowAnonymous]
        [HttpPost]
        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }


    }
}

