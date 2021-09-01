using AutoMapper;
using eRestoran.Model.Requests;
using eRestoran.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Services
{
    public class ProizvodiService : BaseCRUDService<Model.Proizvodi, ProizvodiSearchRequest, Proizvodi, ProizvodiUpsertRequest, ProizvodiUpsertRequest>
    {
        public ProizvodiService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }


        public override List<Model.Proizvodi> Get(ProizvodiSearchRequest request)
        {

            var query = _context.Proizvodi.AsQueryable();
            if (request?.KategorijaId.HasValue == true)
            {
                //query = query.Include(x => x.Kategorija);
                query = query.Where(x => x.KategorijaId == request.KategorijaId);
            }
            //if (request?.Naziv.HasValue == true)
            //{
            //    query = query.Where(x => x.KategorijaId == request.KategorijaId);
            //}

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(request.Naziv));
            }
            //if (!string.IsNullOrWhiteSpace(request?.Naziv))
            //{
            //    query = query.Where(x => x.Naziv.StartsWith(request.Naziv));
            //}
            //if (!string.IsNullOrWhiteSpace(request?.Sadrzaj))
            //{
            //    query = query.Where(x => x.Sadrzaj.StartsWith(request.Sadrzaj));
            //}
            var list = query.ToList();
            //return base.Get(search);
            return _mapper.Map<List<Model.Proizvodi>>(list);

        }
    }
}