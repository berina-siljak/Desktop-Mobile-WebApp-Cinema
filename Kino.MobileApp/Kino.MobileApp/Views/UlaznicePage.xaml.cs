using Kino.MobileApp.ViewModels;
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
    }
}