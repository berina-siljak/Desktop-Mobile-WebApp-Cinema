using Kino.MobileApp.ViewModels;
using Kino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stripe;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Kino.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlacanjePage : ContentPage
    {
        private readonly APIService _ulazniceService = new APIService("Ulaznice");

        private UlazniceViewModel model = null;
        public PlacanjePage(Ulaznice ulaznica)
        {
            InitializeComponent();
            BindingContext = model = new UlazniceViewModel()
            {
                Ulaznica = ulaznica
            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
        }

        private async void Plati_OnClicked(object sender, EventArgs e)
        {
            StripeConfiguration.ApiKey = "sk_test_51GwzwECMfSWm2wuKdY0WobeCmk8znyb7KbhEA22EYmoXz8KbZB0KrqiTBFH8e8f9IoHzMvdU5l9syGPbaQLmJ81r00agCcQ51v";

            Token stripeToken = null;

            try
            {
                var tokenOprions = new TokenCreateOptions()
                {
                    Card = new CreditCardOptions()
                    {
                        Number = CreditCardNumber.Text,
                        ExpMonth = Convert.ToInt64(CreditCardExpMonth.Text),
                        ExpYear = Convert.ToInt64(CreditCardExpYear.Text),
                        Cvc = CreditCardSecurityCode.Text
                    }
                };

                var tokenService = new TokenService();
                stripeToken = tokenService.Create(tokenOprions);

                var customer = new CustomerCreateOptions
                {
                    Description = "Naplata za kupca",
                    Name = APIService.Username, 
                    Source = stripeToken.Id 
                };
                var customerService = new CustomerService();
                var customerResponse = customerService.Create(customer);

                // `source` is obtained with Stripe.js; see https://stripe.com/docs/payments/accept-a-payment-charges#web-create-token
                var options = new ChargeCreateOptions
                {
                    Amount = (long)model.Ulaznica.CijenaSaPopustom * 100,
                    Currency = "BAM",
                    Customer = customerResponse.Id,
                    Description = "Nova uplata",
                };
                var service = new ChargeService();
                service.Create(options);
                model.Ulaznica.Datum = DateTime.Now;
                await _ulazniceService.Insert<Ulaznice>(model.Ulaznica);
                await DisplayAlert("Obavijest", "Uspješno ste kupili kartu!", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Greška!", "Niste unijeli tačne podatke", "OK");
            }
        }
    }

}