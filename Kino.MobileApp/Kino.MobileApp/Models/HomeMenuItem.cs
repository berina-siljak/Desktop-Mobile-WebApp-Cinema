using System;
using System.Collections.Generic;
using System.Text;

namespace Kino.MobileApp.Models
{
    public enum MenuItemType
    {
        Browse,
        Odjava,
        Filmovi,
        Projekcije,
        Ulaznice,
        Pocetna,
        Profil
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
