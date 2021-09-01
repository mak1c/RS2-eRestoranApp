using AutoMapper;
using eRestoran.Model.Requests;
using eRestoran.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Services
{
    public class KategorijaService : BaseCRUDService<Model.Kategorija, KategorijaSearchRequest, Kategorija, KategorijaUpsertRequest, KategorijaUpsertRequest>
    {
        public KategorijaService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public int Prebroj(KategorijaSearchRequest search)
        {
     

            var query = _context.Kategorija.AsQueryable();
           
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(search.Naziv));
            }
           
            var list = query.ToList();
            //return base.Get(search);
            var velicina = list.Count();

        
            return velicina;
        }
        public override List<Model.Kategorija> Get(KategorijaSearchRequest search)
        {
            var query = _context.Set<Kategorija>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(search.Naziv));
            }

            //query = query.OrderBy(x => x.Naziv);

            var list = query.ToList();
            //return base.Get(search);
            return _mapper.Map<List<Model.Kategorija>>(list);
        }
        //public override List<Model.Kategorija> Get(Model.Requests.KategorijaSearchRequest search)
        //{
        //    return base.Get(search);
        //}
    }

   

}
