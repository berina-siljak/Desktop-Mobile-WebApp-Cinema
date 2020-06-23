using Kino.Model;
using Kino.Model.Requests;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Kino.MobileApp.ViewModels
{
    public class PreporukeViewModel : BaseViewModel
    {
        private readonly APIService _preporukeService = new APIService("Preporuke");
        private readonly APIService _kupciService = new APIService("Kupci");

        public ObservableCollection<Filmovi> FilmoviList { get; set; } = new ObservableCollection<Filmovi>();

        public PreporukeViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            try
            {
            KupciSearchRequest searchKupaca = new KupciSearchRequest();
            searchKupaca.KorisnickoIme = APIService.Username;
            List<Kupci> lista = await _kupciService.Get<List<Kupci>>(searchKupaca);
            var kupac = lista.First();

            var list = await _preporukeService.GetById<List<Filmovi>>(kupac.KupacID);
            FilmoviList.Clear();
            foreach (var item in list)
            {
                FilmoviList.Add(item);
            }
            }
            catch (System.Exception)
            {
                FilmoviList = new ObservableCollection<Filmovi>();
            }
        }


    }
}
