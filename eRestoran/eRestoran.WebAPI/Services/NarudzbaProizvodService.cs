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
    public class NarudzbaProizvodService : BaseCRUDService<Model.NarudzbaProizvod, NarudzbaProizvodSearchRequest, Database.NarudzbaProizvod, NarudzbaProizvodUpsertRequest, NarudzbaProizvodUpsertRequest>
    {
        public NarudzbaProizvodService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.NarudzbaProizvod> Get(NarudzbaProizvodSearchRequest search)
        {
            List<Model.NarudzbaProizvod> lista = new List<Model.NarudzbaProizvod>();

            var narudzbastavke = _context.NarudzbaProizvod.Include(x => x.Proizvod).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.NarudzbaId.ToString()))
            {
                narudzbastavke = narudzbastavke.Where(w => w.NarudzbaId == search.NarudzbaId);
            }

            if (search.ProizvodId!=0)
            {
                narudzbastavke = narudzbastavke.Where(w => w.ProizvodId == search.ProizvodId);
            }
            var narudzbepro = narudzbastavke.ToList();
            foreach (var item in narudzbepro)
            {
                double cijenaU = item.Cijena /item.Kolicina;
                lista.Add(new Model.NarudzbaProizvod
                {
                    NarudzbaProizvodId = item.NarudzbaProizvodId,
                    Cijena = cijenaU,
                    Proizvod = item.Proizvod.Naziv,
                    ProizvodId = item.ProizvodId,
                    Ukupno= item.Cijena,
                    Kolicina = item.Kolicina,
                    NarudzbaId = item.NarudzbaId
                });
                cijenaU = 0;
            }

            return lista;
        }

        public override Model.NarudzbaProizvod GetById(int id)
        {
            var item = _context.NarudzbaProizvod.Where(w => w.NarudzbaProizvodId == id)
                .Include(x => x.Proizvod)
                .SingleOrDefault();


            Model.NarudzbaProizvod model = new Model.NarudzbaProizvod
            {
                NarudzbaProizvodId = item.NarudzbaProizvodId,
                Cijena = item.Cijena,
                Proizvod = item.Proizvod.Naziv,
                ProizvodId = item.ProizvodId,
                Kolicina = item.Kolicina,
                NarudzbaId = item.NarudzbaId
            };

            return model;
        }

        public override Model.NarudzbaProizvod Insert(NarudzbaProizvodUpsertRequest request)
        {
            Database.NarudzbaProizvod narudzbaStavke = new Database.NarudzbaProizvod();

            narudzbaStavke.Cijena = request.Cijena;
            narudzbaStavke.Kolicina = request.Kolicina;
            narudzbaStavke.NarudzbaId = request.NarudzbeId;
            narudzbaStavke.ProizvodId = request.ProizvodId;
            _context.Add(narudzbaStavke);

            _context.SaveChanges();

            return _mapper.Map<Model.NarudzbaProizvod>(narudzbaStavke);

        }

        public override Model.NarudzbaProizvod Update(int id, NarudzbaProizvodUpsertRequest request)
        {
            var narudzbaStavke = _context.NarudzbaProizvod.Find(id);

            narudzbaStavke.Cijena = request.Cijena;
            narudzbaStavke.Kolicina = request.Kolicina;
            narudzbaStavke.NarudzbaId = request.NarudzbeId;

            _context.NarudzbaProizvod.Attach(narudzbaStavke);
            _context.NarudzbaProizvod.Update(narudzbaStavke);

            _context.SaveChanges();

            return _mapper.Map<Model.NarudzbaProizvod>(narudzbaStavke);
        }


    }
}
