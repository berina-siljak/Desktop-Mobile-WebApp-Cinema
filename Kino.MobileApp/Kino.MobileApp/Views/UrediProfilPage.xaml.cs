using Kino.MobileApp.ViewModels;
using Kino.Model;
using Kino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Kino.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UrediProfilPage : ContentPage
    {

        UrediProfilViewModel vm = null;

        public UrediProfilPage()
        {
            InitializeComponent();
            BindingContext = vm = new UrediProfilViewModel();

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await vm.Init();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {

            if (!Regex.IsMatch(this.Ime.Text, @"^[a-zA-Z]+$"))
            {
                await DisplayAlert("Greška", "Ime se sastoji samo od slova", "OK");
            }
            else if (!Regex.IsMatch(this.Prezime.Text, @"^[a-zA-Z]+$"))
            {
                await DisplayAlert("Greška", "Prezime se sastoji samo od slova", "OK");
            }
            else if (!Regex.IsMatch(this.Telefon.Text, @"^[+]{1}\d{3}[ ]?\d{2}[ ]?\d{3}[ ]?\d{3}"))
            {
                await DisplayAlert("Greška", "Format telefona je: +123 45 678 910", "OK");
            }
            else if (!Regex.IsMatch(this.Email.Text, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"))
            {
                await DisplayAlert("Greška", "Neispravan format email-a!", "OK");

            }
            else if (!Regex.IsMatch(this.KorisnickoIme.Text, @"^(?=.{4,40}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$"))
            {
                await DisplayAlert("Greška", "Neispravan format ili dužina korisničkog imena (4-40)", "OK");
            }
            else if (string.IsNullOrWhiteSpace(this.Lozinka.Text))
            {
                await DisplayAlert("Greška", "Morate unijeti novu ili staru lozinku", "OK");

            }
            else if (this.Lozinka.Text != this.PotvrdaLozinke.Text)
            {
                await DisplayAlert("Greška", "Lozinke moraju biti iste", "OK");

            }
            else if (this.Lozinka.Text.Length < 4)
            {
                await DisplayAlert("Greška", "Lozinka ne smije biti kraća od 4 karaktera", "OK");
            }

            else
            {
                try
                {
                    vm.Ime = this.Ime.Text;
                    vm.Prezime = this.Prezime.Text;
                    vm.Telefon = this.Telefon.Text;
                    vm.Email = this.Email.Text;
                    vm.KorisnickoIme = this.KorisnickoIme.Text;
                    vm.Lozinka = this.Lozinka.Text;
                    vm.PotvrdaLozinke = this.PotvrdaLozinke.Text;


                    await vm.Uredi();
                    if (APIService.Username != this.KorisnickoIme.Text || !string.IsNullOrWhiteSpace(this.Lozinka.Text))
                    {
                        await Application.Current.MainPage.DisplayAlert("Poruka", "Uspjesno ste izmijenili podatke!", "OK");

                        Application.Current.MainPage = new PocetnaPage();
                    }
                    else
                        await Navigation.PopAsync();
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }
        }
    }
}