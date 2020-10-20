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
    public class ZadatakDetailViewModel:BaseViewModel
    {
        private readonly APIService _apiServiceKupci = new APIService("Kupci");
        private readonly APIService _apiServiceProjekcije = new APIService("Projekcije");
        private readonly APIService _apiServiceUlaznice = new APIService("Ulaznice");


        public ZadatakDetailViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public NoviModel NoviModel { get; set; }
        public ObservableCollection<Projekcije> ProjekcijeList { get; set; } = new ObservableCollection<Projekcije>();
        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
           
            ProjekcijeList.Clear();
            var ulaznice = await _apiServiceUlaznice.Get<List<Ulaznice>>(new UlazniceSearchRequest { KupacID = NoviModel.KupacID });
            foreach (var ul in ulaznice)
            {
                var projekcije = await _apiServiceProjekcije.GetById<Projekcije>(ul.ProjekcijaID);
                    ProjekcijeList.Add(new Projekcije
                    {
                        Film = projekcije.Film
                    });

              
              
            }
        }
    }
}
