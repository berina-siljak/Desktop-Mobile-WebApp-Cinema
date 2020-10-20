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
    public partial class UlazniceDetailPage : ContentPage
    {
        private UlazniceDetailViewModel model = null;

        public UlazniceDetailPage(Ulaznice ulaznica)
        {
            InitializeComponent();
            BindingContext = model = new UlazniceDetailViewModel()
            {
                Ulaznice = ulaznica
            };
        }


    }
}