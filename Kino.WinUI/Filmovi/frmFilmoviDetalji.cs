using EvoPdf;
using Kino.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino.WinUI.Filmovi
{
    public partial class frmFilmoviDetalji : Form
    {
        APIService _service = new APIService("Filmovi");
        APIService _zanroviservice = new APIService("Zanrovi");
        FilmoviInsertRequest request = new FilmoviInsertRequest();

        private int? _id = null;

        public frmFilmoviDetalji(int? korisnikId = null)
        {
            InitializeComponent();
            _id = korisnikId;
        }


        private async void FrmFilmovi_Load(object sender, EventArgs e)
        {
            await LoadZanrovi();
            if (_id.HasValue)
            {
                var filmovi = await _service.GetById<Model.Filmovi>(_id);
                request.Slika = filmovi.Slika;
                txtNazivFilma.Text = filmovi.Naziv;
                txtOpis.Text = filmovi.Opis;
                txtRežiser.Text = filmovi.Reziser;
                txtTrajanje.Text = (filmovi.Trajanje).ToString();
                textBoxGlumci.Text = filmovi.Glumci;
                textBoxGodina.Text = filmovi.GodinaIzdavanja;
                if (filmovi.Slika.Length != 0)
                {
                    pictureBox1.Image = BytesToImage(filmovi.Slika);
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.logo;
                }
                comboBoxZanrovi.SelectedValue = int.Parse(filmovi.ZanrId.ToString());

            }
        }

        private async Task LoadZanrovi()
        {
            var result = await _zanroviservice.Get<List<Model.Zanrovi>>(null);
            comboBoxZanrovi.DataSource = result;
            comboBoxZanrovi.DisplayMember = "Naziv";
            comboBoxZanrovi.ValueMember = "ZanrID";
            comboBoxZanrovi.SelectedItem = null;
            comboBoxZanrovi.SelectedText = "--Odaberite--";

        }

        public Image BytesToImage(byte[] arr)
        {
            MemoryStream ms = new MemoryStream(arr);
            return Image.FromStream(ms);
        }





        private async void SnimiButton_Click(object sender, EventArgs e)
        {

            var idObj = comboBoxZanrovi.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int zanrid))
            {
                request.ZanrID = zanrid;

                request.Naziv = txtNazivFilma.Text;
                request.Opis = txtOpis.Text;
                request.Reziser = txtRežiser.Text;
                request.Trajanje = int.Parse(txtTrajanje.Text);
                request.Glumci = textBoxGlumci.Text;
                request.GodinaIzdavanja = textBoxGodina.Text;

            }

            if (_id.HasValue)
            {
                try
                {
                    await _service.Update<Model.Filmovi>(_id.Value, request);
                    MessageBox.Show("Uspješno sačuvani podaci");
                    this.Close();
                }

                catch (Exception)
                {
                    DialogResult r = MessageBox.Show("Nemate pravo pristupa");
                    if (r == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                try
                {
                    await _service.Insert<Model.Filmovi>(request);
                    MessageBox.Show("Uspješno sačuvani podaci");
                    this.Close();
                }

                catch (Exception)
                {
                    DialogResult r = MessageBox.Show("Nemate pravo pristupa");
                    if (r == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
        }

        private async void BtnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);

                request.Slika = file;
                txtSlika.Text = fileName;

                Image image = Image.FromFile(fileName);
                pictureBox1.Image = image;
            }
        }

  
        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNazivFilma.Text))
            {
                errorProvider1.SetError(txtNazivFilma, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtNazivFilma.Text, @"^[a-zA-Z ]+$"))
            {
                errorProvider1.SetError(txtNazivFilma, Properties.Resources.NeispravanFormat);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtNazivFilma, null);
            }
        }

        private void txtOpis_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtOpis.Text))
            {
                errorProvider1.SetError(txtOpis, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtOpis.Text, @"^[a-zA-Z ]+$"))
            {
                errorProvider1.SetError(txtOpis, Properties.Resources.NeispravanFormat);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtOpis, null);
            }
        }

        private void txtReziser_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRežiser.Text))
            {
                errorProvider1.SetError(txtRežiser, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtRežiser.Text, @"^[a-zA-Z ]+$"))
            {
                errorProvider1.SetError(txtRežiser, Properties.Resources.NeispravanFormat);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtRežiser, null);
            }
        }

        private void txtTrajanje_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTrajanje.Text))
            {
                errorProvider1.SetError(txtTrajanje, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtTrajanje.Text, @"^[0-9]+$"))
            {
                errorProvider1.SetError(txtTrajanje, Properties.Resources.NeispravanFormat);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtTrajanje, null);
            }
        }

    }
}
