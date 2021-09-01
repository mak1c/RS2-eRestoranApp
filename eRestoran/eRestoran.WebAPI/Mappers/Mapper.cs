using AutoMapper;
using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Mappers
{
 
    public class Mapper : Profile
    {
        public Mapper()
        {

            CreateMap<Database.Korisnici, Model.Korisnici>();
            CreateMap<Database.Obavijest, Model.Obavijest>();
            CreateMap<Database.JediniceMjere, Model.JediniceMjere>();
            CreateMap<Database.Kategorija, Model.Kategorija>();
            CreateMap<Database.Proizvodi, Model.Proizvodi>();
            CreateMap<Database.Uloge, Model.Uloge>();
            CreateMap<Database.NarudzbaStatus, Model.NarudzbaStatus>();
            CreateMap<Database.Informacije, Model.Informacije>();
            //CreateMap<ICollection<Database.KorisniciUloge>, ICollection<Model.KorisniciUloge>>();
            //CreateMap<Database.KorisniciUloge, Model.KorisniciUloge>();
            CreateMap<Database.Narudzbe, Model.Narudzbe>();
            CreateMap<Database.Ocjena, Model.Ocjena>();
            CreateMap<Database.NarudzbaProizvod, Model.NarudzbaProizvod>();
            //CreateMap<ICollection<Database.KorisniciUloge>, ICollection<Model.KorisniciUloge>>();
            //inserts
            CreateMap<Database.Kategorija, KategorijaUpsertRequest>().ReverseMap();
            CreateMap<Database.Korisnici, KorisniciInsertRequest>().ReverseMap();
            CreateMap<Database.Korisnici, KorisniciUpdateRequest>().ReverseMap();
            CreateMap<Database.Obavijest, ObavijestInsertRequest>().ReverseMap();
            CreateMap<Database.Proizvodi, ProizvodiUpsertRequest>().ReverseMap();
            CreateMap<Database.Narudzbe, NarudzbaUpsertRequest>().ReverseMap();
            CreateMap<Database.NarudzbaProizvod, NarudzbaProizvodUpsertRequest>().ReverseMap();
            CreateMap<Database.Informacije, InformacijeUpsertRequest>().ReverseMap();
            CreateMap<Database.Ocjena, OcjenaInsertRequest>().ReverseMap();

        }
    }
}
