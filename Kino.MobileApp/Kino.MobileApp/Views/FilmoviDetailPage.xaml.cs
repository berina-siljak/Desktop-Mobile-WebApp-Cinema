using Kino.MobileApp.ViewModels;
using Kino.Model;
//using Syncfusion.SfRating.XForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Kino.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(false)]
    public partial class FilmoviDetailPage : ContentPage
    {
        private readonly APIService _komentariService = new APIService("Komentari");
        private readonly APIService _ocjeneService = new APIService("Ocjene");

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
        private async void ButtonKomentar_Clicked(object sender, EventArgs e)
        {
            model.Komentar.VrijemeKreiranja = DateTime.Now;
            await _komentariService.Insert<Komentari>(model.Komentar);
            model.Komentar.Sadrzaj = "";
            await model.Init();
        }
        private async void ButtonTrailer_Clicked(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(model.Filmovi.VideoUrl))
            await Browser.OpenAsync(model.Filmovi.VideoUrl, new BrowserLaunchOptions
            {
                LaunchMode = BrowserLaunchMode.SystemPreferred,
                TitleMode = BrowserTitleMode.Show,
                PreferredToolbarColor = Color.AliceBlue,
                PreferredControlColor = Color.Violet
            });
        }

        private async void ButtonPodijeli_Clicked(object sender, EventArgs e)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Uri = model.Filmovi.VideoUrl,
                Title = model.Filmovi.Naziv
            });
        }
      
    }
}