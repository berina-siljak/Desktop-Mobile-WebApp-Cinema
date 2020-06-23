using Kino.Model.Requests;
using Kino.WinUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino.WinUI.Kupci
{
    public partial class frmKupciDetalji : Form
    {
        APIService _service = new APIService("Kupci");

        private int? _id = null;
        public frmKupciDetalji(int? korisnikId = null)
        {
            InitializeComponent();
            _id = korisnikId;
        }
        public frmKupciDetalji()
        {
            InitializeComponent();
        }

      

        private async void FrmKupciDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var kupac = await _service.GetById<Model.Kupci>(_id);

                txtIme.Text = kupac.Ime;
                txtPrezime.Text = kupac.Prezime;
                txtEmail.Text = kupac.Email;
                txtTelefon.Text = kupac.Telefon;
                txtKorisnickoIme.Text = kupac.KorisnickoIme;
            }

        }
        private async void BtnSnimi_Click(object sender, EventArgs e)
        {
            var request = new KupciInsertRequest
            {
                Email = txtEmail.Text,
                Ime = txtIme.Text,
                KorisnickoIme = txtKorisnickoIme.Text,
                Password = txtPassword.Text,
                PasswordPotvrda = txtPotvrda.Text,
                Prezime = txtPrezime.Text,
                Telefon = txtTelefon.Text,
            };

            if (!_id.HasValue)
            {
                var entity = await _service.Insert<Model.Kupci>(request);
            }
            else
            {
                await _service.Update<Model.Kupci>(_id.Value, request);
            }

            MessageBox.Show("Uspješno izvršeno");
            this.Close();
        }

        private void TxtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                errorProvider1.SetError(txtIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtIme.Text, @"^[a-zA-Z ]+$"))
            {
                errorProvider1.SetError(txtIme, Properties.Resources.NeispravanFormat);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtIme, null);
            }
        }

        private void TxtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                errorProvider1.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtPrezime.Text, @"^[a-zA-Z ]+$"))
            {
                errorProvider1.SetError(txtPrezime, Properties.Resources.NeispravanFormat);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtIme, null);
            }
        }


        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void TxtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) || txtKorisnickoIme.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }
        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTelefon.Text))
            {
                errorProvider1.SetError(txtTelefon, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtTelefon.Text, @"^[+]{1}\d{3}[ ]?\d{2}[ ]?\d{3}[ ]?\d{3}"))
            {
                errorProvider1.SetError(txtTelefon, "Format telefona je: +123 45 678 910");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtTelefon, null);
            }
        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }
        }
        private void txtPotvrda_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPotvrda.Text))
            {
                errorProvider1.SetError(txtPotvrda, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (txtPotvrda.Text != txtPassword.Text)
            {
                errorProvider1.SetError(txtPotvrda, "Passwordi se ne poklapaju");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPotvrda, null);
            }
        }
    }
}

