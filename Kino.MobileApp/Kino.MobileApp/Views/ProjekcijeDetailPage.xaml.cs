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
    public partial class ProjekcijeDetailPage : ContentPage
    {
        private ProjekcijeDetailViewModel model = null;
        public ProjekcijeDetailPage(Projekcije projekcija)
        {
            InitializeComponent();
            BindingContext = model = new ProjekcijeDetailViewModel()
            {
                Projekcije = projekcija
            };
        }

        private async void KupiKartu_Clicked(object sender, EventArgs e)
        {
            var item = model.Projekcije;
            await Navigation.PushAsync(new OdabirSjedistaPage(item));
        }
    }
}