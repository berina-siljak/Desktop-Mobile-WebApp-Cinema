using Kino.MobileApp.ViewModels;
using Kino.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Kino.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(false)]
    public partial class ZadatakPage : ContentPage
    {
        public ZadatakPage()
        {
            InitializeComponent();
            BindingContext = new RattingBarViewModal();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}