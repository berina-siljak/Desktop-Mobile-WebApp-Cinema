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
    public class SjedistaViewModel : BaseViewModel
    {
        private APIService _apiServiceSjedista = new APIService("Sjedista");
        private APIService _apiServiceKupci = new APIService("Kupci");
        private APIService _apiServiceUlaznice = new APIService("Ulaznice");
        public SjedistaViewModel()
        {
            InitCommand = new Command(async () => await Init());
            Projekcija = null;
        }
        public SjedistaViewModel(Projekcije projekcija)
        {
            InitCommand = new Command(async () => await Init());
            Projekcija = projekcija;
        }
        public ObservableCollection<Sjedista> SjedistaList { get; set; } = new ObservableCollection<Sjedista>();
        public Projekcije Projekcija { get; set; }
        public Kupci Kupac { get; set; }
        public Ulaznice Ulaznica { get; set; }

        public int BrojRedova { get; set; }
        public int BrojKolona { get; set; }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            IsBusy = true;
            var username = APIService.Username;
            List<Kupci> listKupaca = await _apiServiceKupci.Get<List<Kupci>>(null);
            Kupac = listKupaca.FirstOrDefault(x => x.KorisnickoIme == username);

            SjedistaSearchRequest search = new SjedistaSearchRequest();
            search.SalaID = Projekcija.SalaID;
            var listaSjedista = await _apiServiceSjedista.Get<List<Sjedista>>(search);
            UlazniceSearchRequest search2 = new UlazniceSearchRequest();
            search2.ProjekcijaID = Projekcija.ProjekcijaID;
            var ulaznice = await _apiServiceUlaznice.Get<List<Model.Ulaznice>>(search2);
            var brojRedova = listaSjedista.Max(x => x.OznakaReda);
            var brojKolona = listaSjedista.Max(x => x.OznakaKolone);
            if (int.TryParse(brojRedova, out int brojReda))
            {
                BrojRedova = brojReda;
            }
            if (int.TryParse(brojKolona, out int brojKolon))
            {
                BrojKolona = brojKolon;
            }
            foreach (var ulaznica in ulaznice)
            {
                var odabranoSjediste = listaSjedista.FirstOrDefault(x => x.SjedisteID == ulaznica.SjedisteID);
                if(odabranoSjediste != null)
                {
                    odabranoSjediste.Zauzeto = true;
                }
            }
            Ulaznica = new Ulaznice()
            {
                Datum = DateTime.Now,
                KupacID = Kupac.KupacID,
                Popust = 0,
                ProjekcijaID = Projekcija.ProjekcijaID,
                CijenaSaPopustom = Projekcija.Cijena
            };
            SjedistaList.Clear();
            foreach (var sjediste in listaSjedista)
            {
                SjedistaList.Add(sjediste);
            }
        }

    }
}
