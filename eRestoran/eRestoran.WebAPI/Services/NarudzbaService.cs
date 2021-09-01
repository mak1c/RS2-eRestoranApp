using AutoMapper;
using eRestoran.Model.Requests;
using eRestoran.WebAPI.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Services
{
    public class NarudzbaService : BaseCRUDService<Model.Narudzbe, Model.Requests.NarudzbeSearchRequest, Database.Narudzbe, Model.Requests.NarudzbaUpsertRequest, Model.Requests.NarudzbaUpsertRequest>
    {
        public NarudzbaService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Narudzbe> Get(NarudzbeSearchRequest search)
        {
            List<Model.Narudzbe> lista = new List<Model.Narudzbe>();

            var narudzba = _context.Narudzbe.Include(x => x.NarudzbaStatus).AsQueryable();
            if (search.KorisnikId != 0)
            {
                narudzba = narudzba.Where(w => w.KorisnikId == search.KorisnikId);
            }
            if (search.NarudzbaStatusId!=0)
            {
                narudzba = narudzba.Where(x => x.NarudzbaStatusId == search.NarudzbaStatusId);
            }
            if (search.DatumPretraga ==true)
            {
                narudzba = narudzba.Where(x => x.DatumNarudžbe.Date == search.DatumNarudzbe.Date);
            }
            narudzba = narudzba.OrderByDescending(x=>x.NarudzbeId);
          


            foreach (var item in narudzba)
            {
                lista.Add(new Model.Narudzbe
                {
                    NarudzbeId = item.NarudzbeId,
                    DatumNarudžbe = item.DatumNarudžbe,

                    NarudzbaStatusId = item.NarudzbaStatusId,
                    NarudzbaStatus =item.NarudzbaStatus.Status,
                    KorisnikId = item.KorisnikId,
                    Adresa=item.Adresa,
                    PaymentId = item.PaymentId,
                    ZaUplatiti = item.ZaUplatiti,
                    Placena =item.Placena,
                    BrojTelefona=item.BrojTelefona,
                    Korisnik = _context.Korisnici.Where(w => w.KorisnikId == item.KorisnikId).Select(w => w.Ime + " " + w.Prezime).FirstOrDefault()
                });
            }

            return lista;
        }

        public override Model.Narudzbe GetById(int id)
        {
            var item = _context.Narudzbe.Where(w => w.NarudzbeId == id).Include(x => x.Korisnik).Include(x => x.NarudzbaStatus)
                .SingleOrDefault();

            var korisnikImeP = _context.Korisnici.Where(w => w.KorisnikId == item.KorisnikId).Select(w => w.Ime + " " + w.Prezime).FirstOrDefault();
            

            Model.Narudzbe model = new Model.Narudzbe
            {
                NarudzbeId = item.NarudzbeId,
                DatumNarudžbe = item.DatumNarudžbe,
                Placena = item.Placena,
                NarudzbaStatusId = item.NarudzbaStatusId,
                NarudzbaStatus = item.NarudzbaStatus.Status,
                KorisnikId = item.KorisnikId,
                ZaUplatiti = item.ZaUplatiti,
                PaymentId=item.PaymentId,
                Korisnik = korisnikImeP,
                Adresa = item.Adresa,
                BrojTelefona = item.BrojTelefona,
            };

            return model;
        }


        public override Model.Narudzbe Update(int id, NarudzbaUpsertRequest request)
        {

            var obj = _context.Narudzbe.Find(id);
            if (request.NarudzbaStatusId!=0)
            {
                obj.NarudzbaStatusId = request.NarudzbaStatusId;
            }
            if (request.Placena)
            {
                obj.Placena = request.Placena;
                obj.PaymentId = request.PaymentId;

            }

            _context.Narudzbe.Update(obj);
            _context.SaveChanges();
            var novi = _mapper.Map<Model.Narudzbe>(obj);
            return novi;

        }

        public override Model.Narudzbe Insert(NarudzbaUpsertRequest request)
        {

            Database.Narudzbe nova = new Database.Narudzbe();
            nova.KorisnikId = request.KorisnikId;
          
            nova.NarudzbaStatusId = 1;
            nova.Placena = false;
            nova.BrojTelefona = _context.Korisnici.Where(x => x.KorisnikId == request.KorisnikId).Select(x => x.Telefon).FirstOrDefault();
            nova.Adresa = request.Adresa;
            nova.DatumNarudžbe = DateTime.Now;
            nova.ZaUplatiti = request.ZaUplatiti;
          
            _context.Narudzbe.Add(nova);
            _context.SaveChanges();
            var novi = _mapper.Map<Model.Narudzbe>(nova);
            return novi;
  

        }

       
    }
}
