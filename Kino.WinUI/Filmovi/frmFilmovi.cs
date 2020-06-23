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

namespace Kino.WinUI.Filmovi
{
    public partial class frmFilmovi : Form
    {
        private readonly APIService _apiService = new APIService("Filmovi");

        public frmFilmovi()
        {
            InitializeComponent();
        }


        private async void BtnPrikazi_Click(object sender, EventArgs e)
        {
            FilmoviSearchRequest search = new FilmoviSearchRequest()
            {
                Naziv = txtFilmovi.Text
            };

            var list = await _apiService.Get<List<Model.Filmovi>>(search);
            dgvFilmovi.AutoGenerateColumns = false;
            dgvFilmovi.DataSource = list;

        }
        private void DgvFilmovi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvFilmovi.SelectedRows[0].Cells[0].Value;
            frmFilmoviDetalji frm = new frmFilmoviDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private async void FrmFilmovi_Load(object sender, EventArgs e)
        {
            FilmoviSearchRequest search = new FilmoviSearchRequest()
            {
                Naziv = txtFilmovi.Text
            };

            var list = await _apiService.Get<List<Model.Filmovi>>(search);
            dgvFilmovi.AutoGenerateColumns = false;
            dgvFilmovi.DataSource = list;
        }

    }
}
