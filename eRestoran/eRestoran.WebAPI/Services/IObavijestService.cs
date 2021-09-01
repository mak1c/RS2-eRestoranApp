using eRestoran.Model;
using eRestoran.Model.Requests;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Services
{
    public interface IObavijestService
    {

        //IList<Model.Obavijest> Get(ObavijestSearchRequest request);
        //Model.Obavijest Insert(ObavijestInsertRequest request);
        //Model.Obavijest GetById(int id);
        List<Obavijest> Get();
        Obavijest GetById(int id);

    }
}
