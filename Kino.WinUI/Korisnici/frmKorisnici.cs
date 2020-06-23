using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using Kino.Model.Requests;

namespace Kino.WinUI.Korisnici
{
    public partial class frmKorisnici : Form
    {
        private readonly APIService _apiService = new APIService("Korisnici");
        public frmKorisnici()
        {
            InitializeComponent();
        }

        private async void FrmKorisnici_Load(object sender, EventArgs e)
        {
            KorisniciSearchRequest search = new KorisniciSearchRequest()
            {
                Ime = txtPretraga.Text
            };

            var list = await _apiService.Get<List<Model.Korisnici>>(search);
            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.DataSource = list;
        }

        private async void BtnPrikazi_Click(object sender, EventArgs e)
        {
            KorisniciSearchRequest search = new KorisniciSearchRequest()
            {
                Ime = txtPretraga.Text
            };

            var list = await _apiService.Get<List<Model.Korisnici>>(search);
            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.DataSource = list;

        }

        private void DgvKorisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKorisnici.SelectedRows[0].Cells[0].Value;
            frmKorisniciDetalji frm = new frmKorisniciDetalji(int.Parse(id.ToString()));
            frm.Show();

        }

      
    }
}
