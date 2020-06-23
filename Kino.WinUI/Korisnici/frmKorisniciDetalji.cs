using Kino.Model;
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

namespace Kino.WinUI.Korisnici
{
    public partial class frmKorisniciDetalji : Form
    {
        APIService _service = new APIService("Korisnici");
        APIService _ulogeService = new APIService("Uloge");

        private int? _id = null;
        public frmKorisniciDetalji(int? korisnikId=null)
        {
            InitializeComponent();
            _id = korisnikId;
        }


        private async void frmKorisniciDetalji_Load(object sender, EventArgs e)
        {
            var uloge = await _ulogeService.Get<List<Model.Uloge>>(null);
            clbRole.DataSource = uloge;
            clbRole.DisplayMember = "Naziv";
            if (_id.HasValue)
            {
                var korisnik = await _service.GetById<Model.Korisnici>(_id);

                txtIme.Text = korisnik.Ime;
                txtPrezime.Text = korisnik.Prezime;
                txtEmail.Text = korisnik.Email;
                txtTelefon.Text = korisnik.Telefon;
                txtKorisnickoIme.Text = korisnik.KorisnickoIme;
                foreach (var uloga in korisnik.KorisniciUloge)
                {
                    clbRole.SetSelected(uloge.IndexOf(uloga.Uloga),true);
                }
            }
        }



        private async void BtnSnimi_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
               

                var ulogeList = clbRole.CheckedItems.Cast<Uloge>();
                var ulogeIdList = ulogeList.Select(x => x.UlogaID).ToList();
                var request = new KorisniciInsertRequest
                {
                    Email = txtEmail.Text,
                    Ime = txtIme.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Password = txtPassword.Text,
                    PasswordConfirmation = txtPotvrda.Text,
                    Prezime = txtPrezime.Text,
                    Telefon = txtTelefon.Text,
                    
                    Uloge=ulogeIdList
                };

                if (!_id.HasValue)
                {
                    var entity = await _service.Insert<Model.Korisnici>(request);
                }
                else
                {
                    await _service.Update<Model.Korisnici>(_id.Value, request);
                }

                MessageBox.Show("Uspješno izvršeno");
                this.Close();
            }
        }

        private void TxtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                errorProvider.SetError(txtIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtIme.Text, @"^[a-zA-Z ]+$"))
            {
                errorProvider.SetError(txtIme, Properties.Resources.NeispravanFormat);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void TxtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtPrezime.Text, @"^[a-zA-Z ]+$"))
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.NeispravanFormat);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }


        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void TxtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) || txtKorisnickoIme.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }
        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTelefon.Text))
            {
                errorProvider.SetError(txtTelefon, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtTelefon.Text, @"^[+]{1}\d{3}[ ]?\d{2}[ ]?\d{3}[ ]?\d{3}"))
            {
                errorProvider.SetError(txtTelefon, "Format telefona je: +123 45 678 910");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtTelefon, null);
            }
        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPassword, null);
            }
        }
        private void txtPotvrda_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPotvrda.Text))
            {
                errorProvider.SetError(txtPotvrda, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (txtPotvrda.Text != txtPassword.Text)
            {
                errorProvider.SetError(txtPotvrda, "Passwordi se ne poklapaju");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPotvrda, null);
            }
        }

        private void FrmKorisniciDetalji_FormClosing(object sender, FormClosingEventArgs e)
        {

            AutoValidate = AutoValidate.Disable;
            //this.Close();
        }
    }
}
