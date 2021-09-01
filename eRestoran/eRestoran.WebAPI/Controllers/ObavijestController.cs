using eRestoran.Model;
using eRestoran.Model.Requests;

using eRestoran.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace eRestoran.WebAPI.Controllers
{

    public class ObavijestController : BaseCRUDController<Model.Obavijest, ObavijestSearchRequest, ObavijestInsertRequest, ObavijestInsertRequest>
    {
        public ObavijestController(ICRUDService<Obavijest, ObavijestSearchRequest, ObavijestInsertRequest, ObavijestInsertRequest> service) : base(service)
        {
        }
    }

    //[Authorize]
    //[Route("api/[controller]")]
    //[ApiController]
    //public class ObavijestController : ControllerBase
    //{
    //    private readonly IObavijestService _obavijestService;
    //    public ObavijestController(IObavijestService obavijestService)
    //    {
    //        _obavijestService = obavijestService;
    //    }
    //    // GET: api/<Obavijest>
    //    [HttpGet]
    //    public ActionResult<IList<Model.Obavijest>> Get([FromQuery]ObavijestSearchRequest request)
    //    {
    //        var list = _obavijestService.Get(request);
    //        return Ok(list);
    //    }

    //    // GET api/<Obavijest>/5
    //    [HttpGet("{id}")]
    //    public string Get(int id)
    //    {
    //        return "value";
    //    }

    //    // POST api/<Obavijest>
    //    [HttpPost]
    //    public Model.Obavijest Insert(ObavijestInsertRequest request)
    //    {
    //        return _obavijestService.Insert(request);
    //    }

    //    // PUT api/<Obavijest>/5
    //    [HttpPut("{id}")]
    //    public void Put(int id, [FromBody] string value)
    //    {
    //    }

    //    // DELETE api/<Obavijest>/5
    //    [HttpDelete("{id}")]
    //    public void Delete(int id)
    //    {
    //    }
    //}
}
