using Kino.MobileApp.Views;
using Kino.Model;
using Kino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private readonly APIService _ocjeneService = new APIService("Ocjene");

        public FilmoviDetailViewModel()
        {
            InitCommand = new Command(async () => await Init());
            clickCommand = new Command(onClicked); // this will execute on the click of Click me button.
        }
        public Filmovi Filmovi { get; set; }
        public Komentari _komentar = null;
        public Komentari Komentar
        {
            get { return _komentar; }
            //set { _prosjecnaOcjena = value; NotifyPropertyChanged(); }
            set { SetProperty(ref _komentar, value); }
        }
        public Ocjene Ocjena { get; set; }
        public double _prosjecnaOcjena = 0;
        public double ProsjecnaOcjena
        {
            get { return _prosjecnaOcjena; }
            //set { _prosjecnaOcjena = value; NotifyPropertyChanged(); }
            set { SetProperty(ref _prosjecnaOcjena, value); }
        }
        public string _brojGlasova = "(0)";
        public string BrojGlasova
        {
            get { return _brojGlasova; }
            set { SetProperty(ref _brojGlasova, value); }
            //set { _brojGlasova = value; NotifyPropertyChanged(); }
        }
        public ObservableCollection<Komentari> KomentariList { get; set; } = new ObservableCollection<Komentari>();
        public ObservableCollection<Ocjene> OcjeneList { get; set; } = new ObservableCollection<Ocjene>();

        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            KomentariSearchRequest search = new KomentariSearchRequest();
            OcjeneSearchRequest search2 = new OcjeneSearchRequest();
            search.FilmID = Filmovi.FilmID;
            search2.FilmID = Filmovi.FilmID;
            var komentariList = await _komentariService.Get<List<Komentari>>(search);
            var ocjeneList = await _ocjeneService.Get<List<Ocjene>>(search);
            KomentariList.Clear();
            OcjeneList.Clear();

            foreach (var komentar in komentariList.ToList())
            {
                KomentariList.Add(komentar);
            }
            foreach (var ocjena in ocjeneList.ToList())
            {
                OcjeneList.Add(ocjena);
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
            Ocjena = new Ocjene()
            {
                FilmID = Filmovi.FilmID,
                KupacID = kupac.KupacID,
            };
            if (OcjeneList.Count > 0)
            {
                ProsjecnaOcjena = OcjeneList.Average(x => x.Ocjena);
                BrojGlasova = "(" + OcjeneList.Count() + ")";
            }
        }

        public ICommand clickCommand { get; set; }

        async void onClicked(object obj)
        {
            RattingBar b = (RattingBar)obj;
            Ocjena.Ocjena = b.SelectedStarValue;
            await _ocjeneService.Insert<Ocjene>(Ocjena);

            await App.Current.MainPage.DisplayAlert("Ocijenili ste film sa:", b.SelectedStarValue.ToString() + " zvjedica!", "OK");
            await Init();
        }

        private string _selectedStar;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string SelectedStar
        {
            get { return _selectedStar; }
            set { _selectedStar = value; NotifyPropertyChanged(); }
        }
    }
}
