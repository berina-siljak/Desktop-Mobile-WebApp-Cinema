//using Kino.Model;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using Xamarin.Forms;
//using Xamarin.Forms.Xaml;

//namespace Kino.MobileApp.Views
//{
//    [XamlCompilation(XamlCompilationOptions.Compile)]
//    public partial class OcjenePage : ContentPage
//    {
//        public APIService _apiserviceKupac = new APIService("Kupci");
    
//        public OcjenePage()
//        {
//            InitializeComponent();
//            BindingContext = model = new OcjeneViewModel() {  };
//        }
//        protected override async void OnAppearing()
//        {
//            base.OnAppearing();

//            await model.Init()/*;*/
//        }

//        private async void Button_Clicked(object sender, EventArgs e)
//        {
//            if (!decimal.TryParse(this.Ocjena.Text, out decimal Ocjena) || Ocjena < 1 || Ocjena > 10)
//            {
//                await DisplayAlert("Greška", "Ocjena mora biti između 1 i 10.", "OK");
//                return;
//            }

//            Kupci kupac = new Kupci();
//            var username = APIService.Username;
//            List<Kupci> lista = await _apiserviceKupac.Get<List<Kupci>>(null);
//            foreach (var k in lista)
//            {
//                if (k.KorisnickoIme == username)
//                {
//                    kupac = k;
//                    break;
//                }
//            }
            

//            await model.DodajOcjenu();
//        }

//    }
//}