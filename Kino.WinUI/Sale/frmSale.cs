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

namespace Kino.WinUI.Sale
{

    public partial class frmSale : Form
    {
        private readonly APIService _apiService = new APIService("Sale");

        public frmSale()
        {
            InitializeComponent();
        }

        private async void BtnPrikazi_Click(object sender, EventArgs e)
        {
            SaleSearchRequest search = new SaleSearchRequest()
            {
                Naziv = txtSale.Text
            };

            var list = await _apiService.Get<List<Model.Sale>>(search);
            dgvSale.AutoGenerateColumns = false;
            dgvSale.DataSource = list;
        }

    
        private async void Sale_Load(object sender, EventArgs e)
        {
            SaleSearchRequest search = new SaleSearchRequest()
            {
                Naziv = txtSale.Text
            };

            var list = await _apiService.Get<List<Model.Sale>>(search);
            dgvSale.AutoGenerateColumns = false;
            dgvSale.DataSource = list;
        }

        private void DgvSale_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvSale.SelectedRows[0].Cells[0].Value;
            frmSaleDetalji frm = new frmSaleDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
