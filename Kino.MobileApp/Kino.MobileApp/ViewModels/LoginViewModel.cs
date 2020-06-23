using Kino.MobileApp.Views;
using Kino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Kino.MobileApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Kupci");
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
            APIService.Username = "";
            APIService.Password = "";
        }
        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public ICommand LoginCommand { get; set; }

        async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;

            try
            {
                await _service.Get<dynamic>(null);
                Kupci kupac = null;
                List<Kupci> lista = await _service.Get<List<Kupci>>(null);
                kupac = lista.FirstOrDefault(x => x.KorisnickoIme == Username);
                if (kupac != null)
                {
                    Application.Current.MainPage = new MainPage();
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Nemate pravo pristupa!", "OK");
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                IsBusy = false;
            }


        }
    }
}

