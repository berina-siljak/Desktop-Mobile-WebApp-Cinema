using Kino.Model.Requests;
using Kino.WinUI.Filmovi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino.WinUI.Kupci
{
    public partial class frmKupci : Form
    {
        private readonly APIService _apiService = new APIService("Kupci");

        public frmKupci()
        {
            {
                InitializeComponent();
            }

        }
            private async void FrmKupci_Load(object sender, EventArgs e)
            {
                KupciSearchRequest search = new KupciSearchRequest()
                {
                    Ime = txtPretraga.Text
                };

                var list = await _apiService.Get<List<Model.Kupci>>(search);
                dgvKupci.AutoGenerateColumns = false;
                dgvKupci.DataSource = list;
            }

        private async void ButtonPrikazi_Click(object sender, EventArgs e)
        {
            KupciSearchRequest search = new KupciSearchRequest()
            {
                Ime = txtPretraga.Text
            };

            var list = await _apiService.Get<List<Model.Kupci>>(search);
            dgvKupci.AutoGenerateColumns = false;
            dgvKupci.DataSource = list;
        }

        private void DgvKupci_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKupci.SelectedRows[0].Cells[0].Value;
            frmKupciDetalji frm = new frmKupciDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}

