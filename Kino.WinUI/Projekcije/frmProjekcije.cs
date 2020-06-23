using Kino.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino.WinUI.Projekcije
{
    public partial class frmProjekcije : Form
    {
        private readonly APIService _apiService = new APIService("Projekcije");
        private readonly APIService _apiServiceFilmovi = new APIService("Filmovi");
        private static List<Model.Filmovi> filmovi;
        public frmProjekcije()
        {
            InitializeComponent();
        }

        private async void FrmProjekcije_Load(object sender, EventArgs e)
        {
            await LoadSveFilmove();

        }
        private async Task LoadSveFilmove()
        {
            filmovi = await _apiServiceFilmovi.Get<List<Model.Filmovi>>(null);
            cmbFilmovi.DisplayMember = "Naziv";
            cmbFilmovi.ValueMember = "FilmID";
            cmbFilmovi.DataSource = filmovi;
            cmbFilmovi.Text = "--Odaberite film--";
        }
        private async Task LoadProjekcije(int id)
        {
            var result = await _apiService.Get<List<Model.Projekcije>>(new ProjekcijeSearchRequest()
            {
                FilmID= id,
                sveProjekcije = true
            });
            dgvProjekcije.AutoGenerateColumns = false;
            dgvProjekcije.DataSource = result;
        }

        public Image BytesToImage(byte[] arr)
        {
            MemoryStream ms = new MemoryStream(arr);
            return Image.FromStream(ms);
        }

        private async void CmbFilmovi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var filmObjId = cmbFilmovi.SelectedValue;

            if (filmObjId != null && int.TryParse(filmObjId.ToString(), out int filmid))
            {
                await LoadProjekcije(filmid);
                var film = filmovi.First(x => x.FilmID == filmid);
                if (film.Slika.Length != 0)
                {
                    slikaFilma.Image = BytesToImage(film.Slika);
                }
                else
                {
                    slikaFilma.Image = Properties.Resources.logo;
                }
            }
        }

   

        private void DgvProjekcije_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvProjekcije.SelectedRows[0].Cells[0].Value;
            frmProjekcijeDetalji frm = new frmProjekcijeDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
