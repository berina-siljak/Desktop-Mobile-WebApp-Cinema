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
    class ProjekcijeViewModel :BaseViewModel
    {
        private readonly APIService _projekcijeService = new APIService("Projekcije");
        private readonly APIService _filmoviService = new APIService("Filmovi");

        public ProjekcijeViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Projekcije> ProjekcijeList { get; set; } = new ObservableCollection<Projekcije>();
        public ObservableCollection<Filmovi> FilmoviList { get; set; } = new ObservableCollection<Filmovi>();

        Filmovi _selectedFilmovi = null;
        //property
        public Filmovi SelectedFilm
        {
            get {
                return _selectedFilmovi; }
            set
            {

                SetProperty(ref _selectedFilmovi, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }


        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            if (FilmoviList.Count == 0)
            {
                var filmovilist = await _filmoviService.Get<List<Filmovi>>(null);

                foreach (var zanrovi in filmovilist.ToList())
                {
                    FilmoviList.Add(zanrovi);
                }
            }
            if (SelectedFilm != null)
            {
                ProjekcijeSearchRequest search = new ProjekcijeSearchRequest();
                search.FilmID = SelectedFilm.FilmID;
                var list = await _projekcijeService.Get<IEnumerable<Projekcije>>(search);
                ProjekcijeList.Clear();
                foreach (var projekcije in list)
                {
                    ProjekcijeList.Add(projekcije);
                }
            }


        }
    }
}
