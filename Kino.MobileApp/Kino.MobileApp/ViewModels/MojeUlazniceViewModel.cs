using Kino.Model;
using Kino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Kino.MobileApp.ViewModels
{
    public class MojeUlazniceViewModel : BaseViewModel
    {
        private readonly APIService _ulazniceService = new APIService("Ulaznice");
        private readonly APIService _kupciService = new APIService("Kupci");
        public ObservableCollection<Ulaznice> UlazniceList { get; set; } = new ObservableCollection<Ulaznice>();

        public MojeUlazniceViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            KupciSearchRequest searchKupaca = new KupciSearchRequest();
            searchKupaca.KorisnickoIme = APIService.Username;
            List<Kupci> lista = await _kupciService.Get<List<Kupci>>(searchKupaca);
            var kupac = lista.First();
            UlazniceSearchRequest search = new UlazniceSearchRequest();
            search.KupacID = kupac.KupacID;
            var list = await _ulazniceService.Get<List<Ulaznice>>(search);
            UlazniceList.Clear();
            foreach (var ulaznica in list)
            {
                UlazniceList.Add(ulaznica);
            }
        }
    }
}
