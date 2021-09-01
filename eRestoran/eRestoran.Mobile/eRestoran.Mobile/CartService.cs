using eRestoran.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Mobile
{
    public static class CartService
    {
        public static Dictionary<int, ProizvodDetaljiViewModel> Cart { get; set; } = new Dictionary<int, ProizvodDetaljiViewModel>();
    }
}
