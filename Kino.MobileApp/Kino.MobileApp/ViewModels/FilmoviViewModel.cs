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
    public class FilmoviViewModel : BaseViewModel
    {
        private readonly APIService _filmoviService = new APIService("Filmovi");
        private readonly APIService _zanroviService = new APIService("Zanrovi");

        public FilmoviViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }


        public ObservableCollection<Filmovi> FilmoviList { get; set; } = new ObservableCollection<Filmovi>();
        public ObservableCollection<Zanrovi> ZanroviList { get; set; } = new ObservableCollection<Zanrovi>();
        Zanrovi _selectedZanrovi = null;
        //property
        public Zanrovi SelectedZanr
        {
            get { return _selectedZanrovi; }
            set
            {

                SetProperty(ref _selectedZanrovi, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }


        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            if (ZanroviList.Count == 0)
            {
                var zanroviList = await _zanroviService.Get<List<Zanrovi>>(null);
                var filmoviList = await _filmoviService.Get<List<Filmovi>>(null);

                foreach (var zanrovi in zanroviList.ToList())
                {
                    ZanroviList.Add(zanrovi);
                }
                foreach (var filmovi in filmoviList.ToList())
                {
                    FilmoviList.Add(filmovi);
                }
            }
            if (SelectedZanr != null)
            {
                FilmoviSearchRequest search = new FilmoviSearchRequest();
                search.ZanrID = SelectedZanr.ZanrID;
                var list = await _filmoviService.Get<IEnumerable<Filmovi>>(search);
                FilmoviList.Clear();
                foreach (var filmovi in list)
                {
                    FilmoviList.Add(filmovi);
                }
            }
    

        }
    }

}
