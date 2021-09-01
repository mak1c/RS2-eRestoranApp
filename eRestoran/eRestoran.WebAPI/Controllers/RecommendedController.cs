using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRestoran.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eRestoran.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecommenderController : ControllerBase
    {

        private readonly IRecommender _service;

        public RecommenderController(IRecommender service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetSimilarArticles/{ArticleId}")]
        public List<Model.Proizvodi> GetSimilarArticles(int ArticleId)
        {
            return _service.GetSimilarArticles(ArticleId);
        }
    }
}