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
    public class FilmoviDetailViewModel : BaseViewModel
    {
        private readonly APIService _komentariService = new APIService("Komentari");
        private readonly APIService _kupciService = new APIService("Kupci");
        public FilmoviDetailViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public Filmovi Filmovi { get; set; }
        public Komentari Komentar { get; set; }
        public ObservableCollection<Komentari> KomentariList { get; set; } = new ObservableCollection<Komentari>();
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            KomentariSearchRequest search = new KomentariSearchRequest();
            search.FilmID = Filmovi.FilmID;
            var komentariList = await _komentariService.Get<List<Komentari>>(search);
            KomentariList.Clear();
            foreach (var komentar in komentariList.ToList())
            {
                KomentariList.Add(komentar);
            }

            KupciSearchRequest searchKupaca = new KupciSearchRequest();
            searchKupaca.KorisnickoIme = APIService.Username;
            List<Kupci> lista = await _kupciService.Get<List<Kupci>>(searchKupaca);
            var kupac = lista.First();
            Komentar = new Komentari()
            {
                FilmID = Filmovi.FilmID,
                VrijemeKreiranja = DateTime.Now,
                KupacID = kupac.KupacID
            };
        }
    }
}
