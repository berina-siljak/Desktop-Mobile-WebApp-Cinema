using Kino.Model;
using Kino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Kino.MobileApp.ViewModels
{
    public class ZadatakViewModel:BaseViewModel
    {
        private APIService _apiServiceProjekcije = new APIService("Projekcije");
        private APIService _apiServiceUlaznice = new APIService("Ulaznice");
        private APIService _apiServiceKupci = new APIService("Kupci");


        public ZadatakViewModel()
        {
            InitCommand = new Command(async () => await Init());


        }

        public ObservableCollection<NoviModel> novaLista { get; set; } = new ObservableCollection<NoviModel>();



        public ICommand InitCommand { get; set; }


        private DateTime _datumOd;

        public DateTime DatumOd
        {
            get { return _datumOd; }
            set { SetProperty(ref _datumOd, value); }
        }

        private DateTime _datumDo;

        public DateTime DatumDo
        {
            get { return _datumDo; }
            set { SetProperty(ref _datumDo, value); }
        }
      

        private decimal _ukupnaZarada;

        public decimal UkupnaZarada
        {
            get { return _ukupnaZarada; }
            set { SetProperty(ref _ukupnaZarada, value); }
        }

        private decimal _Max;

        public decimal Max
        {
            get { return _Max; }
            set { SetProperty(ref _Max, value); }
        }
        private string _search;

        public string Search
        {
            get { return _search; }
            set { SetProperty(ref _search, value); }
        }

        public async Task Init()
        {
            DatumOd = DateTime.Now;
            DatumDo = DateTime.Now;

        }

        public async Task Prikazi()
        {
            novaLista.Clear();
            UkupnaZarada = 0;

            var projekcije = await _apiServiceProjekcije.Get<List<Projekcije>>(new ProjekcijeSearchRequest { DatumOd = DatumOd, DatumDo = DatumDo }) ;

                foreach (var pr in projekcije)
                {
                    if (pr.Datum>=DatumOd && pr.Datum<=DatumDo)
                    {
                        var ulaznice = await _apiServiceUlaznice.Get<List<Ulaznice>>(new UlazniceSearchRequest { ProjekcijaID = pr.ProjekcijaID });
                        foreach (var ul in ulaznice)
                        {
                            var kupac = await _apiServiceKupci.GetById<Kupci>(ul.KupacID);
                            bool postoji = false;
                            foreach (var lista in novaLista)
                            {
                                if (ul.KupacID == lista.KupacID)
                                {
                                    postoji = true;
                                    lista.Uplata += ul.CijenaSaPopustom;
                                }
                            }
                            if (!postoji)
                            {
                                decimal uplata = 0;

                                foreach (var u in ulaznice)
                                {
                                    if (u.KupacID == kupac.KupacID)
                                    {
                                        uplata += u.CijenaSaPopustom;
                                    }
                                }
                            if (uplata >= Max)
                            {
                                novaLista.Add(new NoviModel
                                {
                                    KupacID = kupac.KupacID,
                                    Uplata = uplata,
                                    Kupac = kupac.Ime + " " + kupac.Prezime,
                                    Projekcija = pr.Film,
                                    ProjekcijaID = pr.ProjekcijaID
                                });
                                UkupnaZarada += uplata;
                            }


                            }

                        }
                    }
                }

            }
        }
}






         
          
        

   
