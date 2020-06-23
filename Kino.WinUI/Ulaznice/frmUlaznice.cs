using Kino.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino.WinUI.Ulaznice
{
    public partial class frmUlaznice : Form
    {
        private readonly APIService _apiService = new APIService("Ulaznice");
        private readonly APIService _apiServiceKupci = new APIService("Kupci");
        public frmUlaznice()
        {
            InitializeComponent();
        }

        private async void FrmUlaznice_Load(object sender, EventArgs e)
        {
            await LoadSviKupci();
            var result = await _apiService.Get<List<Model.Ulaznice>>(null);
            dgvUlaznice.AutoGenerateColumns = false;
            dgvUlaznice.DataSource = result;
        }
 
        private async Task LoadSviKupci()
        {
            var result = await _apiServiceKupci.Get<List<Model.Kupci>>(null);
            comboBoxKupci.DataSource = result;
            comboBoxKupci.DisplayMember = "ImePrezimeKupca";
            comboBoxKupci.ValueMember = "KupacID";
            
            comboBoxKupci.Text = "--Odaberite kupca--";
        }
        private async Task LoadUlaznice(int id)
        {
            var result = await _apiService.Get<List<Model.Ulaznice>>(new UlazniceSearchRequest()
            {
                KupacID = id
            });
            dgvUlaznice.AutoGenerateColumns = false;
            dgvUlaznice.DataSource = result;
        }

        private async void ComboBoxKupci_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = comboBoxKupci.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadUlaznice(id);
            }
        }
    }
}
