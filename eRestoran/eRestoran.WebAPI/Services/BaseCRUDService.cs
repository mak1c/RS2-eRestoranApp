using AutoMapper;
using eRestoran.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Services
{
    public class BaseCRUDService<TModel, TSearch, TDatabase, TInsert, TUpdate> : BaseService<TModel, TSearch, TDatabase>, ICRUDService<TModel, TSearch, TInsert, TUpdate> where TDatabase : class
    {
        public BaseCRUDService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public virtual TModel Insert(TInsert request)
        {
            var entity = _mapper.Map<TDatabase>(request);

            _context.Set<TDatabase>().Add(entity);
            _context.SaveChanges();

            return _mapper.Map<TModel>(entity);


        }


        public virtual TModel Update(int id, TUpdate request)
        {
            var entity = _context.Set<TDatabase>().Find(id);
            _context.Set<TDatabase>().Attach(entity);
            _context.Set<TDatabase>().Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<TModel>(entity);
        }
        public virtual HttpResponseMessage Delete(int id)
        {
            var entity = _context.Set<TDatabase>().Find(id);
            if (entity == null)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            _context.Remove(entity);
            _context.SaveChanges();
            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }
    }
}
