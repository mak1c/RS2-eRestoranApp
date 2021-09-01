using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Services
{
    public interface IRecommender
    {
        List<Model.Proizvodi> GetSimilarArticles(int ProizvodId);
    }

}
