using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using eRestoran.Mobile.Models;
using eRestoran.Mobile.Services;
using System.Linq;

namespace eRestoran.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }
        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();
        //}

        //protected override void OnDisappearing()
        //{
        //    base.OnAppearing();
        //}

        //private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    if (ToolbarItems.Count > 0)
        //    {
        //        DependencyService.Get<IToolbarItemBadgeService>().SetBadge(this, ToolbarItems.First(), $"{e.NewValue}", Color.Red, Color.White);
        //    }


        //}
        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.EditProfil:
                        MenuPages.Add(id, new NavigationPage(new EditProfilPage()));
                        break;
                    case (int)MenuItemType.Proizvodi:
                        MenuPages.Add(id, new NavigationPage(new ProizvodiPage()));
                        break;
                    case (int)MenuItemType.Narudzba:
                        MenuPages.Add(id, new NavigationPage(new NarudzbaPage()));
                        break;
                    case (int)MenuItemType.Obavijesti:
                        MenuPages.Add(id, new NavigationPage(new ObavijestiPage()));
                        break;
                    case (int)MenuItemType.SveNarudzbe:
                        MenuPages.Add(id, new NavigationPage(new NarudzbeAllPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }

        }
        
    }
}