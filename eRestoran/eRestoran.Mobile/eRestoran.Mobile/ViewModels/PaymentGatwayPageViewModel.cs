using Acr.UserDialogs;
using eRestoran.Mobile.Models.PaymentGateway;
using eRestoran.Mobile.Views;
using eRestoran.Model;
using eRestoran.Model.Requests;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eRestoran.Mobile.ViewModels
{
    public class PaymentGatewayViewModel : BindableBase
    {
        #region Variable
        private APIService _serviceN = new APIService("Narudzbe");
        private APIService _serviceK = new APIService("Korisnici");
        private CreditCardModel _creditCardModel;
        private TokenService Tokenservice;
        private Token stripeToken;
        private bool _isCarcValid;
        private bool _isTransectionSuccess;
        private string _expMonth;
        private string _expYear;
        private string _title;
        INavigation Navigation;
        #endregion Variable

        #region Public Property
        MainPage RootPage { get => App.Current.MainPage as MainPage; }


        //private string StripeTestApiKey = "pk_test_51J3jygI0cHiKKsAB0HnQdY3dXDV3b7XyKrnL0caWWeFmaSK0yIQPqDqJnt45Bb2k813Rnwigw9TThSWpQnrbfwi700Rm2MxRre";
        private string StripeTestApiKey = "sk_test_51J3jygI0cHiKKsABFhnUYR4tYqVH2QfdPIcaVyQaUSlOd1ZyLWZrlO80VIOrmSOBIqeRVuHwoPTghtMDZAKDOhIw00g9AKhjoi";
        private string StripeSecretApiKey = "sk_test_51J3jygI0cHiKKsABFhnUYR4tYqVH2QfdPIcaVyQaUSlOd1ZyLWZrlO80VIOrmSOBIqeRVuHwoPTghtMDZAKDOhIw00g9AKhjoi";
        public string ExpMonth
        {
            get { return _expMonth; }
            set { SetProperty(ref _expMonth, value); }
        }

        public bool IsCarcValid
        {
            get { return _isCarcValid; }
            set { SetProperty(ref _isCarcValid, value); }
        }

        public bool IsTransectionSuccess
        {
            get { return _isTransectionSuccess; }
            set { SetProperty(ref _isTransectionSuccess, value); }
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string ExpYear
        {
            get { return _expYear; }
            set { SetProperty(ref _expYear, value); }
        }
        decimal _amount = 0;
        public decimal Amount
        {
            get { return _amount; }
            set { SetProperty(ref _amount, value); }
        }

        int _id = 0;
        public int IdNarudzbe
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        public CreditCardModel CreditCardModel
        {
            get { return _creditCardModel; }
            set { SetProperty(ref _creditCardModel, value); }
        }

        #endregion Public Property

        #region Constructor

        public PaymentGatewayViewModel()
        {
            CreditCardModel = new CreditCardModel();
            Title = "Card Details";
        }
        public PaymentGatewayViewModel(INavigation navigation)
        {
            CreditCardModel = new CreditCardModel();
            Title = "Card Details";
            Navigation = navigation;
        }

        #endregion Constructor

        #region Command

        public DelegateCommand SubmitCommand => new DelegateCommand(async () =>
        {
            CreditCardModel.ExpMonth = Convert.ToInt64(ExpMonth);
            CreditCardModel.ExpYear = Convert.ToInt64(ExpYear);
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            try
            {
                UserDialogs.Instance.ShowLoading("Payment processing..");
                await Task.Run(async () =>
                {

                    var Token = CreateToken();
                    Console.Write("Payment Gateway" + "Token :" + Token);
                    if (Token != null)
                    {
                        IsTransectionSuccess = MakePayment(Token);
                
                        //await navPage.PushAsync(new ProizvodiPage());
                    }
                    else
                    {
                        UserDialogs.Instance.Alert("Bad card credentials", null, "OK");
                    }
                });
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert(ex.Message, null, "OK");
                Console.Write("Payment Gatway" + ex.Message);

            }

            if (IsTransectionSuccess)
            {
                Console.Write("Payment Gateway" + "Payment Successful ");
                UserDialogs.Instance.Alert("Vaša uplata je evidentirana.", "Uplata uspješna!", "OK");
                UserDialogs.Instance.HideLoading();
                //App.Current.MainPage = new NavigationPage(new MainPage());
                await RootPage.NavigateFromMenu(5);
                //Application.Current.MainPage = new MainPage();
                //Xamarin.Forms.Application.Current.MainPage = new NavigationPage(new NarudzbeAllPage());
            }
            else
            {

                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert("Oops, prepoznali smo grešku. Uplata je evidentirana ranije.", "Nije uspjelo plaćanje!", "OK");
                Console.Write("Payment Gateway" + "Payment Failure ");
                App.Current.MainPage = new NavigationPage(new MainPage());
            }


        });

        #endregion Command

        #region Method

        private string CreateToken()
        {
            try
            {
                var korisnik =  _serviceK.GetById<Korisnici>(APIService.Id);
                StripeConfiguration.ApiKey = StripeTestApiKey;
                var service = new ChargeService();
                var Tokenoptions = new TokenCreateOptions
                {

                    Card = new TokenCardOptions
                    {
                        Number = CreditCardModel.Number,
                        ExpYear = CreditCardModel.ExpYear,
                        ExpMonth = CreditCardModel.ExpMonth,
                        Cvc = CreditCardModel.Cvc,
                        Name = korisnik.Result.Ime +" "+korisnik.Result.Prezime,
                        AddressLine1 = "Adewsa 1",
                        AddressLine2 = "Adresa 2",
                        AddressCity = "Mostar",
                        AddressZip = "88000",
                        AddressState = "HNK",
                        AddressCountry = "Bosnia and Herzegovina",
                        Currency = "bam",
                    }
                };

                Tokenservice = new TokenService();
                stripeToken = Tokenservice.Create(Tokenoptions);
                //brojtransakcije
                return stripeToken.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool MakePayment(string token)
        {
            var entity = _serviceN.GetById<Narudzbe>(IdNarudzbe);
        
            if (entity.Result.Placena)
            {
                Console.Write("Plaćena je!");
            }
            else
            {
                try
                {
                    //StripeConfiguration.ApiKey = StripeSecretApiKey;
                    var options = new ChargeCreateOptions
                    {
                        Amount = ((long)Amount) * 100,
                        Currency = "bam",
                        Description = "Uplatio " + APIService.Username,
                        Source = stripeToken.Id,
                        StatementDescriptor = "Custom descriptor",
                        Capture = true,
                        ReceiptEmail = "random.person@gmail.com",
                    };
                    //Make Payment
                    var service = new ChargeService();
                    Charge charge = service.Create(options);
                    NarudzbaUpsertRequest req = new NarudzbaUpsertRequest();
                    req.Placena = true;
                    req.PaymentId = stripeToken.Id;
                    var entitiy = _serviceN.Update<Narudzbe>(IdNarudzbe, req);
                    //App.Current.MainPage = new MainPage();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.Write("Payment Gatway (CreateCharge)" + ex.Message);
                    throw ex;
                }
            }
            return false;
        }

        private bool ValidateCard()
        {
            if (CreditCardModel.Number.Length == 16 && ExpMonth.Length == 2 && ExpYear.Length == 2 && CreditCardModel.Cvc.Length == 3)
            {
                return true;
            }
            return false;
        }

        #endregion Method
    }
}
