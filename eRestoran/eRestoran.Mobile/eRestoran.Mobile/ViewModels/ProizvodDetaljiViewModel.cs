using eRestoran.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eRestoran.Mobile.ViewModels
{

    public class ProizvodDetaljiViewModel:BaseViewModel
    {
        private readonly APIService _RecommenderService = new APIService("Recommender");
        private readonly APIService _OcjenaService = new APIService("Ocjena");


        public ObservableCollection<Ocjena> ArticleRatingsList { get; set; } = new ObservableCollection<Ocjena>();
        public ObservableCollection<Proizvodi> ArticleList { get; set; } = new ObservableCollection<Proizvodi>();
        public ObservableCollection<Proizvodi> RecommenderList { get; set; } = new ObservableCollection<Proizvodi>();


        public ProizvodDetaljiViewModel()
        {
            PovecajKolicinuCommand = new Command(() => Kolicina += 1);
            //NaruciCommand = new Command(Naruci);
            NaruciCommand = new Command(async () => { await Naruci(); });



            InitCommand = new Command(async () => await Init());
            RateWith1Command = new Command(async () => await Ocjeni(1));
            RateWith2Command = new Command(async () => await Ocjeni(2));
            RateWith3Command = new Command(async () => await Ocjeni(3));
            RateWith4Command = new Command(async () => await Ocjeni(4));
            RateWith5Command = new Command(async () => await Ocjeni(5));
            RecommenderCommand = new Command(async () => await Recommender());
        
        }
        public Proizvodi Proizvod { get; set; }

        bool _Rated;
        public bool Rated
        {
            get { return _Rated; }
            set { SetProperty(ref _Rated, value); }
        }


        bool _NotRated;
        public bool NotRated
        {
            get { return _NotRated; }
            set { SetProperty(ref _NotRated, value); }
        }

        double _AverageRating;
        public double AverageRating
        {
            get { return _AverageRating; }
            set { SetProperty(ref _AverageRating, value); }
        }


        public ICommand SendCommand { get; private set; }
        public ICommand IncreaseQuantityCommand { get; set; }
        public ICommand DecreaseQuantityCommand { get; set; }
        public ICommand OrderCommand { get; set; }
        public ICommand RateWith1Command { get; set; }
        public ICommand RateWith2Command { get; set; }
        public ICommand RateWith3Command { get; set; }
        public ICommand RateWith4Command { get; set; }
        public ICommand RateWith5Command { get; set; }
        public ICommand InitCommand { get; set; }

        public ICommand RecommenderCommand { get; set; }


        public async Task Ocjeni(int rating)
        {
            Model.Requests.OcjenaInsertRequest x = new Model.Requests.OcjenaInsertRequest
            {
                ProizvodId = Proizvod.ProizvodId,
                KorisnikId = APIService.Id,
                OcjenaKorisnika = rating,
                DatumOcjenjivanja = DateTime.Now
            };

            await _OcjenaService.Insert<Model.Ocjena>(x);
            Rated = true;
            NotRated = false;
            await App.Current.MainPage.DisplayAlert("Uspješno ste ostavili ocjenu!", "", "OK");

        }




        public async Task Recommender()
        {
            RecommenderList.Clear();
            List<Proizvodi> articlelist = new List<Proizvodi>();
            articlelist = await _RecommenderService.GetSimilarArticles<List<Proizvodi>>(Proizvod.ProizvodId);

            List<Ocjena> ratinglist = new List<Ocjena>();
            ratinglist = await _OcjenaService.Get<List<Ocjena>>(null);

            foreach (var item in articlelist)
            {
                int total = 0;
                decimal amount = 0;

                foreach (var item2 in ratinglist)
                {
                    if (item2.ProizvodId == item.ProizvodId)
                    {
                        amount += item2.OcjenaKorisnika;
                        total++;
                    }
                }

                item.AveragePrice = amount / total;

                RecommenderList.Add(item);
            }
        }


        decimal _kolicina = 1;

        public decimal Kolicina 
        {
            get { return _kolicina; } 
            set{ SetProperty(ref _kolicina, value);
                Cijenaa = +Proizvod.Cijena*_kolicina;
            } 
        }




        decimal _cijenaa = 0;

        public decimal Cijenaa
        {
            get { return _cijenaa; }
            set { SetProperty(ref _cijenaa, value); }
        }
        public ICommand PovecajKolicinuCommand { get; set; }
        public ICommand NaruciCommand { get; set; }
        async Task Naruci()
        {
            var kolic = Convert.ToString(Kolicina);
            if (!Regex.Match(kolic, @"^[0-9]+$", RegexOptions.IgnoreCase).Success)
            {
                await Application.Current.MainPage.DisplayAlert("", "Količina: Dozvoljeni su samo brojevi!", "OK");
                return;
            }
            if (Kolicina != 1)
            {
               
               
            }
            if (Kolicina == 0)
            {
                await Application.Current.MainPage.DisplayAlert("", "Količina: ne može biti 0!", "OK");
                return;
            }
            if (CartService.Cart.ContainsKey(Proizvod.ProizvodId))
            {
                CartService.Cart.Remove(Proizvod.ProizvodId);
            }
            CartService.Cart.Add(Proizvod.ProizvodId, this);
            await Application.Current.MainPage.DisplayAlert("Korpa", "Dodato u korpu!", "OK");
        }





        public async Task Init()
        {
            var Ratinglist = await _OcjenaService.Get<List<Model.Ocjena>>(null);
            Rated = false;
            foreach (var item in Ratinglist)
            {
                if (item.ProizvodId == Proizvod.ProizvodId)
                {
                    ArticleRatingsList.Add(item);
                    if (item.KorisnikId == APIService.Id)
                    {
                        Rated = true;
                    }
                }
            }

            NotRated = !Rated;
            if (ArticleRatingsList.Count() != 0)
            {
                AverageRating = ArticleRatingsList.Select(s => s.OcjenaKorisnika).Average();
            }
            else
            {
                AverageRating = 0;
            }

        }

    }
}
