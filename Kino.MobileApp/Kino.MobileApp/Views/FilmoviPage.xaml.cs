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
    public partial class FilmoviPage : ContentPage
    {
        private FilmoviViewModel model = null;
        public FilmoviPage()
        {
            InitializeComponent();
            BindingContext = model = new FilmoviViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Filmovi;
            await Navigation.PushAsync(new FilmoviDetailPage(item));
        }
    }
}