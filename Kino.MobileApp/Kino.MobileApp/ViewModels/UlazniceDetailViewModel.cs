using Kino.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Kino.MobileApp.ViewModels
{
    public class UlazniceDetailViewModel : BaseViewModel
    {
      
        public UlazniceDetailViewModel()
        {
        }
        public Ulaznice _ulaznice = null;
        public Ulaznice Ulaznice
        {
            get { return _ulaznice; }
            set { SetProperty(ref _ulaznice, value); }
        }

    }
}
