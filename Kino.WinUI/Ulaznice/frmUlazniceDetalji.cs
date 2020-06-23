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

namespace Kino.WinUI.Ulaznice
{
    public partial class frmUlazniceDetalji : Form
    {
        private readonly APIService _ulaznice = new APIService("Ulaznice");
        private readonly APIService _kupci = new APIService("Kupci");
        private readonly APIService _sjedista = new APIService("Sjedista");
        private readonly APIService _projekcije = new APIService("Projekcije");
        private readonly APIService _filmovi = new APIService("Filmovi");
        private static List<Model.Filmovi> filmovi;
        private static List<Model.Projekcije> projekcije;
        private static Model.Projekcije odabranaProjekcija;

        private int? _id = null;
        private int sjedisteId = 0;

        public frmUlazniceDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void FrmUlazniceDetalji_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadKupce();
                await LoadFilmovi();
            }
            catch (Exception ex)
            {
            }
            if (_id.HasValue)
            {
                var ulaznica = await _ulaznice.GetById<Model.Ulaznice>(_id);
                comboBox1Kupci.SelectedValue = int.Parse(ulaznica.KupacID.ToString());
                comboBox3Projekcije.SelectedValue = int.Parse(ulaznica.ProjekcijaID.ToString());
                dtpDatum.Value = ulaznica.Datum;
                dtpVrijeme.Value = ulaznica.Datum;
            }

        }
        private async Task LoadFilmovi()
        {
            filmovi = await _filmovi.Get<List<Model.Filmovi>>(null);

            cmbFilmovi.DataSource = filmovi;
            cmbFilmovi.DisplayMember = "Naziv";
            cmbFilmovi.ValueMember = "FilmID";
            cmbFilmovi.SelectedItem = null;
            cmbFilmovi.SelectedText = "--Odaberite--";
        }
        private async Task LoadKupce()
        {
            var result = await _kupci.Get<List<Model.Kupci>>(null);
            comboBox1Kupci.DataSource = result;
            comboBox1Kupci.DisplayMember = "ImePrezimeKupca";
            comboBox1Kupci.ValueMember = "KupacID";
            comboBox1Kupci.SelectedItem = null;
            comboBox1Kupci.SelectedText = "--Bez Kupca--";
        }

        private async Task LoadSjedista(int id)
        {
            var result = await _sjedista.Get<List<Model.Sjedista>>(new SjedistaSearchRequest()
            {
                SalaID = id,
            });
            var ulaznice = await _ulaznice.Get<List<Model.Ulaznice>>(null);
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.AutoScroll = true;
            var brojRedova = result.Max(x => x.OznakaReda);
            var brojKolona = result.Max(x => x.OznakaKolone);

            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            tableLayoutPanel1.ColumnCount = Convert.ToInt32(brojKolona);
            tableLayoutPanel1.RowCount = Convert.ToInt32(brojRedova);

            foreach (var item in result)
            {
                RadioButton f = new RadioButton();

                f.Text = item.OznakaSjedista;
                f.Tag = item.SjedisteID;
                f.CheckedChanged += new EventHandler(f_CheckedChanged);
                if (ulaznice.FirstOrDefault(x => x.ProjekcijaID == odabranaProjekcija.ProjekcijaID && x.SjedisteID == item.SjedisteID) != null)
                    f.Enabled = false;
                tableLayoutPanel1.Controls.Add(f);
            }

        }
        private async Task LoadProjekcije(int id)
        {
            projekcije = await _projekcije.Get<List<Model.Projekcije>>(new ProjekcijeSearchRequest()
            {
                FilmID = id,
            });
            comboBox3Projekcije.DataSource = projekcije;
            comboBox3Projekcije.DisplayMember = "Datum";
            comboBox3Projekcije.ValueMember = "ProjekcijaID";
            comboBox3Projekcije.SelectedItem = null;
            comboBox3Projekcije.SelectedText = "--Odaberite--";
        }
        UlazniceInsertRequest request = new UlazniceInsertRequest();

        private async void SnimiBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var idObj = comboBox3Projekcije.SelectedValue;

                if (int.TryParse(idObj.ToString(), out int prikazivanjeId))
                {
                    request.ProjekcijaID = prikazivanjeId;
                }

                var kupacIdObj = comboBox1Kupci.SelectedValue;

                if (kupacIdObj != null && int.TryParse(kupacIdObj.ToString(), out int kupacId))
                {
                    request.KupacID = kupacId;
                }

                request.SjedisteID = sjedisteId;
                request.Datum = dtpDatum.Value.Date + dtpVrijeme.Value.TimeOfDay;
                request.CijenaSaPopustom = odabranaProjekcija.Cijena - (odabranaProjekcija.Cijena * Convert.ToInt32(textBoxPopust.Text) / 100);

                if (int.TryParse(textBoxPopust.Text, out int popust))
                {
                    request.Popust = popust;
                }
                else
                {
                    request.Popust = 0;
                }

                if (_id.HasValue)
                {
                    await _ulaznice.Update<Model.Ulaznice>(_id.Value, request);
                }
                else
                {
                    await _ulaznice.Insert<Model.Ulaznice>(request);
                }
                MessageBox.Show("Uspješno sačuvani podaci!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Operacija nije uspjela!");
                this.Close();
            }
        }
        private async void CmbFilmovi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                var filmObjId = cmbFilmovi.SelectedValue;
                tableLayoutPanel1.Controls.Clear();
                comboBox3Projekcije.DataSource = null;
                if (filmObjId != null && int.TryParse(filmObjId.ToString(), out int filmid))
                {
                    await LoadProjekcije(filmid);
                    var film = filmovi.First(x => x.FilmID == filmid);
                    lblNazivFilma.Text = film.Naziv;
                    lblReditelj.Text = film.Reziser;
                    lblZanr.Text = film.NazivZanra;

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
            catch (Exception ex)
            {
            }
        }

        public Image BytesToImage(byte[] arr)
        {
            MemoryStream ms = new MemoryStream(arr);
            return Image.FromStream(ms);
        }

        private async void ComboBox3Projekcije_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                var projekcijaId = comboBox3Projekcije.SelectedValue;
                tableLayoutPanel1.Controls.Clear();

                if (projekcijaId != null && int.TryParse(projekcijaId.ToString(), out int projekcijeId))
                {
                    odabranaProjekcija = projekcije.First(x => x.ProjekcijaID == projekcijeId);
                    lblSala.Text = odabranaProjekcija.Sala != null ? odabranaProjekcija.Sala : "";
                    lblCijena.Text = odabranaProjekcija.Cijena.ToString();
                    await LoadSjedista(odabranaProjekcija.SalaID);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void f_CheckedChanged(object sender, EventArgs e)
        {
          
            sjedisteId = Convert.ToInt32((sender as RadioButton).Tag);
        }

        private void TextBoxPopust_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxPopust.Text, out int popust))
            {
                var temp = decimal.Parse(lblCijena.Text) - (decimal.Parse(lblCijena.Text) * popust / 100);
                lblCijena.Text = Math.Round(temp).ToString();
            }
        }
    }
}

