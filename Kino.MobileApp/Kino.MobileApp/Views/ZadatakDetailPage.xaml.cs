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
 
        public partial class ZadatakDetailPage : ContentPage
        {
            private ZadatakDetailViewModel model = null;
            public ZadatakDetailPage(NoviModel novi)
            {
                InitializeComponent();
                BindingContext = model = new ZadatakDetailViewModel()
                {
                    NoviModel = novi
                };
            }
            protected async override void OnAppearing()
            {
                base.OnAppearing();
                await model.Init();
            }
        }
    
}