using System;
using System.Windows.Input;
using eRestoran.Mobile.Models;
using eRestoran.Model;

namespace eRestoran.Mobile.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {



       

        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;

         
        }
    }
}
