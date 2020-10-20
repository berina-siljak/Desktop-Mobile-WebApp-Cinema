using Kino.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Kino.MobileApp.ViewModels
{
    public class OcjeneViewModel : BaseViewModel
    {
        private APIService _kupac = new APIService("Kupci");
        private APIService _predstava = new APIService("Filmovi");


        public ObservableCollection<Filmovi> PredstavaList { get; set; } = new ObservableCollection<Filmovi>();
        public ObservableCollection<Kupci> KupacList { get; set; } = new ObservableCollection<Kupci>();


        public OcjeneViewModel()
        {
            InitCommand = new Command(async () => await DodajOcjenu());
        }

        public async Task Init()
        {

            Kupci kupac = new Kupci();
            var username = APIService.Username;
            List<Kupci> lista = await _kupac.Get<List<Kupci>>(null);
            foreach (var k in lista)
            {
                if (k.KorisnickoIme == username)
                {
                    kupac = k;
                    break;
                }
            }

            //var request = new PredstavaKupacSearchRequest
            //{
            //    PredstavaId = Predstava.PredstavaId,
            //    KupacId = kupac.KupacId
            //};
            //var entity = await _predstavaKupac.Get<List<PredstavaKupac>>(request);
            //if (entity != null && entity.Count > 0)
            //{
            //    PredstavaKupac = entity[0];
            //    Ocjena = PredstavaKupac.Ocjena;
            //}
        }

        public ICommand InitCommand { get; set; }

        public async Task DodajOcjenu()
        {
            IsBusy = true;
            //if (PredstavaKupac != null)
            //{
            //    await _predstavaKupac.Delete<PredstavaKupac>(PredstavaKupac.PredstavaKupacId);
            //}

            //PredstavaKupac = await _predstavaKupac.Insert<PredstavaKupac>(new PRedstavaKupacInsertRequest()
            //{
            //    Ocjena = _ocjena,
            //    KupacId = _kupacId,
            //    PredstavaId = _predstavaId
            //});
            await Application.Current.MainPage.DisplayAlert(" ", "Uspješno sačuvani podaci", "OK");
        }


        decimal _ocjena = 0;
        public decimal Ocjena
        {
            get { return _ocjena; }
            set { SetProperty(ref _ocjena, value); }
        }

        int _predstavaId = 0;
        public int PredstavaId
        {
            get { return _predstavaId; }
            set { SetProperty(ref _predstavaId, value); }
        }

        int _kupacId = 0;

        public int KupacId
        {
            get { return _kupacId; }
            set { SetProperty(ref _kupacId, value); }
        }

    }
}
