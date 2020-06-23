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

namespace Kino.WinUI.Sale
{
    public partial class frmSaleDetalji : Form
    {
        private readonly APIService _apiService = new APIService("Sale");
        private readonly APIService _apiServiceSjedista = new APIService("Sjedista");
        private int? _id = null;


        public frmSaleDetalji(int? salaId = null)
        {
            InitializeComponent();
            _id = salaId;

        }


        private async void FrmSaleDetalji_Load(object sender, EventArgs e)
        {
           

            var list = await _apiService.Get<List<Model.Sale>>(null);
            dgvSale2.AutoGenerateColumns = false;
            dgvSale2.DataSource = list;

            if (_id.HasValue)
            {
                var sale = await _apiService.GetById<Model.Sale>(_id);
                txtOznaka.Text = sale.Naziv;
                txtBrojRedova.Text = sale.BrojRedova;
                txtBrojKolona.Text = sale.BrojKolona;
            }

        }

        private async void BtnSnimi_Click(object sender, EventArgs e)
        {
            var request = new SaleInsertRequest()
            {
                Naziv = txtOznaka.Text,
                BrojRedova = txtBrojRedova.Text,
                BrojKolona = txtBrojKolona.Text
            };
            if (_id.HasValue)
            {
                await _apiService.Update<Model.Sale>(_id.Value, request);
            }
            else
            {
                var sala = await _apiService.Insert<Model.Sale>(request);
                var sjedista = new SjedistaInsertRequest();
                sjedista.sjedista = new List<Model.Sjedista>();

                //popunjavanje sjedista kad se unese broj redova i broj kolona sale!
                for (int i = 1; i <= Convert.ToInt32(request.BrojRedova); i++)
                {
                    for (int j = 1; j <= Convert.ToInt32(request.BrojKolona); j++)
                    {
                        var sjediste = new Model.Sjedista();
                        sjediste.SalaID = sala.SalaID;
                        sjediste.OznakaReda = i.ToString();
                        sjediste.OznakaKolone = j.ToString();
                        sjedista.sjedista.Add(sjediste);
                    }

                }
                await _apiServiceSjedista.Insert<List<Model.Sjedista>>(sjedista);
            }
            MessageBox.Show("Uspješno sačuvani podaci!");
            this.Close();
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtOznaka.Text))
            {
                errorProvider1.SetError(txtOznaka, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtOznaka, null);
            }
        }
        private void txtBrojRedova_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBrojRedova.Text))
            {
                errorProvider1.SetError(txtBrojRedova, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtBrojRedova.Text, @"[0-9]"))
            {
                errorProvider1.SetError(txtBrojRedova, "Možete unijeti samo brojeve!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtBrojRedova, null);
            }
        }
        private void txtBrojKolona_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBrojKolona.Text))
            {
                errorProvider1.SetError(txtBrojKolona, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtBrojKolona.Text, @"[0-9]"))
            {
                errorProvider1.SetError(txtBrojKolona, "Možete unijeti samo brojeve!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtBrojKolona, null);
            }
        }


    }
}
