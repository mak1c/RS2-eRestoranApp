using AutoMapper;
using eRestoran.Model.Requests;
using eRestoran.WebAPI.Database;
using eRestoran.WebAPI.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace eRestoran.WebAPI.Services
{
    public class ObavijestService : BaseCRUDService<Model.Obavijest, ObavijestSearchRequest, Obavijest, ObavijestInsertRequest, ObavijestInsertRequest>
    {
        public ObavijestService(eRestoranContext context, IMapper mapper) : base(context, mapper)

        { }

        public override List<Model.Obavijest> Get(ObavijestSearchRequest request)
        {

            var query = _context.Obavijest.AsQueryable();
            //   if (request?.Id.HasValue == true)
            //{
            //    query = query.Where(x => x.ObavijestId == request.Id);
            //}
            if (!string.IsNullOrWhiteSpace(request?.Naslov))
            {
                query = query.Where(x => x.Naslov.StartsWith(request.Naslov));
            }
            //if (!string.IsNullOrWhiteSpace(request?.Sadrzaj))
            //{
            //    query = query.Where(x => x.Sadrzaj.StartsWith(request.Sadrzaj));
            //}
            query = query.OrderByDescending(x => x.ObavijestId);
            var list = query.ToList();
            //return base.Get(search);
            return _mapper.Map<List<Model.Obavijest>>(list);

        }
      
    }



}
