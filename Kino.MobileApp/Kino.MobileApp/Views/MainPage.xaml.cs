using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Kino.MobileApp.Models;

namespace Kino.MobileApp.Views
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

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.Pocetna:
                        MenuPages.Add(id, new NavigationPage(new PocetnaPage()));
                        break;
                    case (int)MenuItemType.Filmovi:
                        MenuPages.Add(id, new NavigationPage(new FilmoviPage()));
                        break;
                    case (int)MenuItemType.Projekcije:
                        MenuPages.Add(id, new NavigationPage(new ProjekcijePage()));
                        break;
                    case (int)MenuItemType.Profil:
                        MenuPages.Add(id, new NavigationPage(new UrediProfilPage()));
                        break;
                    case (int)MenuItemType.Ulaznice:
                        MenuPages.Add(id, new NavigationPage(new UlaznicePage()));
                        break;
                    case (int)MenuItemType.Odjava:
                        MenuPages.Add(id, new NavigationPage(new LoginPage()));
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