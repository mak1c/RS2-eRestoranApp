using AutoMapper;
using eRestoran.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Services
{
    public class RecommenderService : IRecommender
    {
        Dictionary<int, List<Model.Ocjena>> Proizvodi = new Dictionary<int, List<Model.Ocjena>>();
        private readonly eRestoranContext _context;
        private readonly IMapper _mapper;

        public RecommenderService(eRestoranContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }



        public List<Model.Proizvodi> GetSimilarArticles(int ProizvodId)
        {
            LoadProizvodi(ProizvodId);

            List<Model.Ocjena> ObservedArticleOcjena = new List<Model.Ocjena>();
            List<Database.Ocjena> recordedOcjena = _context.Ocjene.Where(x => x.OcjenaId == ProizvodId).OrderBy(x => x.KorisnikId).ToList();
            _mapper.Map(recordedOcjena, ObservedArticleOcjena);

            List<Model.Ocjena> CompoundOcjena1 = new List<Model.Ocjena>();
            List<Model.Ocjena> CompoundOcjena2 = new List<Model.Ocjena>();
            List<Model.Proizvodi> recommendedProizvodi = new List<Model.Proizvodi>();

            foreach (var item in Proizvodi)
            {
                foreach (Model.Ocjena r in ObservedArticleOcjena)
                {
                    if (item.Value.Where(x => x.KorisnikId == r.KorisnikId).Count() > 0)
                    {
                        CompoundOcjena1.Add(r);
                        CompoundOcjena2.Add(item.Value.Where(x => x.KorisnikId == r.KorisnikId).First());
                    }
                }
                double similarities = 0;
                similarities = GetSimilarities(CompoundOcjena1, CompoundOcjena2);

                if (similarities > 0.89)
                {
                    Database.Proizvodi element1 = _context.Proizvodi.Include(x => x.Kategorija).Where(x => x.ProizvodId == item.Key).FirstOrDefault();
                    Model.Proizvodi element2 = new Model.Proizvodi();

                    element2.Naziv = element1.Naziv;
                    element2.Cijena = element1.Cijena;
                    element2.ProizvodId = element1.ProizvodId;
                    element2.KategorijaId = element1.KategorijaId;
                    element2.Slika = element1.Slika;
                    element2.SlikaThumb = element1.SlikaThumb;
                    element2.VrijemePripremanja = element1.VrijemePripremanja;
                    element2.Opis = element1.Opis;

                    recommendedProizvodi.Add(element2);

                }
                CompoundOcjena1.Clear();
                CompoundOcjena2.Clear();
            }
            return recommendedProizvodi;

        }

        private double GetSimilarities(List<Model.Ocjena> compoundOcjena1, List<Model.Ocjena> compoundOcjena2)
        {
            if (compoundOcjena1.Count != compoundOcjena2.Count)
                return 0;

            double num1 = 0, num2 = 0, num3 = 0;

            for (int i = 0; i < compoundOcjena1.Count; i++)
            {
                num1 += compoundOcjena1[i].OcjenaKorisnika * compoundOcjena2[i].OcjenaKorisnika;
                num2 += compoundOcjena1[i].OcjenaKorisnika * compoundOcjena1[i].OcjenaKorisnika;
                num3 += compoundOcjena2[i].OcjenaKorisnika * compoundOcjena2[i].OcjenaKorisnika;
            }

            num2 = Math.Sqrt(num2);
            num3 = Math.Sqrt(num3);
            double number = num2 * num3;
            if (number == 0)
                return 0;
            return num1 / number;
        }

        private void LoadProizvodi(int ProizvodId)
        {
            List<Database.Proizvodi> activeProizvodi = _context.Proizvodi.Include(x => x.Kategorija).Where(x => x.ProizvodId != ProizvodId).ToList();

            Database.Proizvodi ObservedArticle = _context.Proizvodi.Where(x => x.ProizvodId == ProizvodId).SingleOrDefault();

            List<Model.Proizvodi> newlist = new List<Model.Proizvodi>();
            _mapper.Map(activeProizvodi, newlist);

            List<Model.Proizvodi> resultlist = new List<Model.Proizvodi>();
            foreach (var item in newlist)
            {
                if (item.KategorijaId == ObservedArticle.KategorijaId)
                {
                    resultlist.Add(item);
                }
            }

            foreach (Model.Proizvodi a in resultlist)
            {
                List<Database.Ocjena> ratinglist = _context.Ocjene.Where(x => x.ProizvodId == a.ProizvodId).ToList();
                List<Model.Ocjena> Ocjena = new List<Model.Ocjena>();
                foreach (var item in ratinglist)
                {
                    Model.Ocjena newrating = new Model.Ocjena();
                    newrating.DatumOcjenjivanja = item.DatumOcjenjivanja;
                    newrating.OcjenaKorisnika = item.OcjenaKorisnika;
                    newrating.ProizvodId = item.ProizvodId;
                    newrating.KorisnikId = item.KorisnikId;
                    newrating.OcjenaId = item.OcjenaId;

                    Ocjena.Add(newrating);
                }
                if (Ocjena.Count > 0)
                    Proizvodi.Add(a.ProizvodId, Ocjena);
            }
        }
    }
}