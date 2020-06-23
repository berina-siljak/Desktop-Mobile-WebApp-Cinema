using Kino.Model.Requests;
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

namespace Kino.WinUI.Zanrovi
{
    public partial class frmZanrovi : Form
    {
        private readonly APIService _apiService = new APIService("Zanrovi");
        private int? _id = null;

        public frmZanrovi(int? zanrId = null)
        {
            InitializeComponent();
            _id = zanrId;
        }

        private async void BtnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new ZanroviSearchRequest()
            {
                Naziv = txtPretraga.Text
            };
            var result = await _apiService.Get<List<Model.Zanrovi>>(search);
            dgvZanrovi.AutoGenerateColumns = false;
            dgvZanrovi.DataSource = result;
        }

        private async void FrmZanrovi_Load(object sender, EventArgs e)
        {
            var search = new ZanroviSearchRequest()
            {
                Naziv = txtPretraga.Text
            };
            var result = await _apiService.Get<List<Model.Zanrovi>>(search);
            dgvZanrovi.AutoGenerateColumns = false;
            dgvZanrovi.DataSource = result;
        }

        private async void SnimiZanr_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new ZanroviInsertRequest()
                {
                    Naziv = txtNazivZanra.Text
                };
                if (_id.HasValue)
                {
                    await _apiService.Update<Model.Zanrovi>(_id.Value, request);
                }
                else
                {
                    await _apiService.Insert<Model.Zanrovi>(request);
                }
                MessageBox.Show("Uspješno sačuvani podaci!");
                this.Close();
            }
        }

        private void txtNazivZanra_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNazivZanra.Text))
            {
                errorProvider1.SetError(txtNazivZanra, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtNazivZanra.Text, @"^[a-zA-Z ]+$"))
            {
                errorProvider1.SetError(txtNazivZanra, Properties.Resources.NeispravanFormat);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtNazivZanra, null);
            }
        }
    }
}
