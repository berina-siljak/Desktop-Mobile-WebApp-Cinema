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

namespace Kino.WinUI.Sjedista
{

    public partial class frmSjedista : Form
    {
        private readonly APIService _apiService = new APIService("Sjedista");
        private readonly APIService _apiServiceSale = new APIService("Sale");



        public frmSjedista()
        {
            InitializeComponent();
            
        }
       

        private async void FrmSjedista_Load(object sender, EventArgs e)
        {
            await LoadSale();

        }
    
        private async Task LoadSjedista(int id)
        {
            var search = new SjedistaSearchRequest()
            {
                SalaID = id
            };
            var list = await _apiService.Get<List<Model.Sjedista>>(search);
            dgvSjedista.AutoGenerateColumns = false;
            dgvSjedista.DataSource = list;
        }
        private async Task LoadSale()
        {
            var sale = await _apiServiceSale.Get<List<Model.Sale>>(null);
            cmbSale.DataSource = sale;
            cmbSale.DisplayMember = "Naziv";
            cmbSale.ValueMember = "SalaID";
            cmbSale.Text = "--Odaberite salu--";
        }

        private async void CmbSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbSale.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadSjedista(id);
            }
        }
    }

}

