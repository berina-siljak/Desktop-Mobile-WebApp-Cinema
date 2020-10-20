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
    public partial class UlaznicePage : ContentPage
    {
        private MojeUlazniceViewModel model = null;
        public UlaznicePage()
        {
            InitializeComponent();
            BindingContext = model = new MojeUlazniceViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Ulaznice;
            await Navigation.PushAsync(new UlazniceDetailPage(item));
        }
    }
}