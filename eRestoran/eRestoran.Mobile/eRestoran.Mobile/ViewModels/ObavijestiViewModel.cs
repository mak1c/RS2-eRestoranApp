using eRestoran.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eRestoran.Mobile.ViewModels
{
   public class ObavijestiViewModel:BaseViewModel
    {
        private readonly APIService _obavijestiService = new APIService("Obavijest");

        public ObavijestiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Obavijest> ObavijestiList { get; set; } = new ObservableCollection<Obavijest>();



        public ICommand InitCommand { get; set; }

        public async Task Init()
        {

            var list = await _obavijestiService.Get<IEnumerable<Obavijest>>(null);

            ObavijestiList.Clear();
            foreach (var obavijest in list)
            {
                ObavijestiList.Add(obavijest);
             
            }


        }
    }
}

