using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Mobile.Models
{
    public enum MenuItemType
    {
        Browse,
        EditProfil,
        Proizvodi,
        Narudzba,
        Obavijesti,
        SveNarudzbe
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
