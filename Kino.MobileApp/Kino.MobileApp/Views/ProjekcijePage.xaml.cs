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
    public partial class ProjekcijePage : ContentPage
    {
        private ProjekcijeViewModel model = null;

        public ProjekcijePage()
        {
            InitializeComponent();
            BindingContext = model = new ProjekcijeViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Projekcije;
            await Navigation.PushAsync(new ProjekcijeDetailPage(item));
        }
    }
}