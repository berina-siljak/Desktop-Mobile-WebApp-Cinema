using Kino.MobileApp.ViewModels;
using Kino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Kino.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OdabirSjedistaPage : ContentPage
    {
        readonly SjedistaViewModel SjedistaViewModel = null;
        public OdabirSjedistaPage(Projekcije projekcija)
        {
            InitializeComponent();
            SjedistaViewModel = new SjedistaViewModel(projekcija);
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await SjedistaViewModel.Init();
            SjedistaViewModel.IsBusy = false;
            this.gridSjedista.Children.Clear();
            this.gridSjedista.RowDefinitions = new RowDefinitionCollection();
            this.gridSjedista.ColumnDefinitions = new ColumnDefinitionCollection();
            this.gridSjedista.RowDefinitions.Add(new RowDefinition());
            var brojSjedista = 0;
            for (int i = 0; i < SjedistaViewModel.BrojRedova; i++)
            {
                this.gridSjedista.RowDefinitions.Add(new RowDefinition { Height = 40 });
                for (int j = 0; j < SjedistaViewModel.BrojKolona; j++)
                {
                    this.gridSjedista.ColumnDefinitions.Add(new ColumnDefinition { Width = 50 });

                Button buttom = new Button
                {
                    MinimumWidthRequest = 50,
                    Text = SjedistaViewModel.SjedistaList[brojSjedista].OznakaSjedista,
                    TextColor = Color.White,
                    CornerRadius = 10,
                    IsEnabled = !SjedistaViewModel.SjedistaList[brojSjedista].Zauzeto,
                    HeightRequest = 40,
                    WidthRequest = 50,
                    FontSize = 12
                };
                    buttom.Pressed += btn_Clicked;
                    if (!buttom.IsEnabled)
                        buttom.BackgroundColor = Color.Gray;
                    else
                        buttom.BackgroundColor = Color.Orange;

                    brojSjedista++;
                    this.gridSjedista.Children.Add(buttom, j, i);
                }
            }

        }
        Button previuosButton = null;
        private void btn_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (previuosButton != null)
            { 
                previuosButton.IsEnabled = true;
                previuosButton.BackgroundColor = Color.Orange;
            }
            SjedistaViewModel.Ulaznica.SjedisteID = SjedistaViewModel.SjedistaList.FirstOrDefault(x => x.OznakaSjedista == btn.Text).SjedisteID;
            previuosButton = btn;
    
            btn.BackgroundColor = Color.Gray;
            btn.IsEnabled = false;
            this.nastavidalje.IsVisible = true;
            this.odabranoSjedalo.Text = btn.Text;
            this.poruka.Text = "Odabrali ste sjedište sa oznakom: " + btn.Text + ".                  Nastavite dalje do plaćanja!";
        }

        private async void NastaviButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlacanjePage(SjedistaViewModel.Ulaznica));
            this.nastavidalje.IsVisible = false;
        }
    }
}