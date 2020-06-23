using Kino.MobileApp.ViewModels;
using Kino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Kino.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilmoviDetailPage : ContentPage
    {
        private readonly APIService _komentariService = new APIService("Komentari");
        private FilmoviDetailViewModel model = null;
        public FilmoviDetailPage(Filmovi film)
        {
            InitializeComponent();
            BindingContext = model = new FilmoviDetailViewModel()
            {
                Filmovi = film
            };
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            model.Komentar.VrijemeKreiranja = DateTime.Now;
            await _komentariService.Insert<Komentari>(model.Komentar);
            model.Komentar.Sadrzaj = "";
            await model.Init();
        }
    }
}