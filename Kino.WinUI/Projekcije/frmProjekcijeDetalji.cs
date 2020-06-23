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

namespace Kino.WinUI.Projekcije
{
    public partial class frmProjekcijeDetalji : Form
    {

        private readonly int? _id = null; 
        private readonly APIService _apiService = new APIService("Projekcije");
        private readonly APIService _apiServiceFilmovi = new APIService("Filmovi");
        private readonly APIService _apiServiceSale = new APIService("Sale");
        private readonly APIService _apiServiceKorisnici = new APIService("Korisnici");

        public frmProjekcijeDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

     

        private async void FrmProjekcijeDetalji_Load(object sender, EventArgs e)
        {
            await LoadSale();
            await LoadFilmovi();
            if (_id.HasValue)
            {
                var projekcije = await _apiService.GetById<Model.Projekcije>(_id);
                dateTimePickerDatum.Value = projekcije.Datum;
                dateTimePickerVrijeme.Value = projekcije.Datum;
                cmbSale.SelectedValue = int.Parse(projekcije.SalaID.ToString());
                cmbFilmovi.SelectedValue = int.Parse(projekcije.FilmID.ToString());
                textBoxCijena.Text = projekcije.Cijena.ToString();
            }

        }
        private async Task LoadSale()
        {
            var result = await _apiServiceSale.Get<List<Model.Sale>>(null);
            cmbSale.DataSource = result;
            cmbSale.DisplayMember = "Naziv";
            cmbSale.ValueMember = "SalaID";
            cmbSale.SelectedItem = null;
            cmbSale.SelectedText = "--Odaberite--";
           
        }
        private async Task LoadFilmovi()
        {
            var result = await _apiServiceFilmovi.Get<List<Model.Filmovi>>(null);
            cmbFilmovi.DataSource = result;
            cmbFilmovi.DisplayMember = "Naziv";
            cmbFilmovi.ValueMember = "FilmID";
            cmbFilmovi.SelectedItem = null;
            cmbFilmovi.SelectedText = "--Odaberite--";
        }

        ProjekcijeInsertRequest req = new ProjekcijeInsertRequest();
        private async void Button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                //List<Model.Sjedista> lista = await _sjediste.Get<List<Model.Sjedista>>(new SjedistaSearchRequest() { Oznaka = txtOznaka.Text, SalaID = int.Parse(cmbSale.SelectedValue.ToString()) });
                var idObj = cmbFilmovi.SelectedValue;

                if (int.TryParse(idObj.ToString(), out int filmid))
                {
                    req.FilmID = filmid;
                }

                var salaIdObj = cmbSale.SelectedValue;

                if (int.TryParse(salaIdObj.ToString(), out int salaId))
                {
                    req.SalaID = salaId;
                }

                req.Datum = dateTimePickerDatum.Value.Date + dateTimePickerVrijeme.Value.TimeOfDay;

                req.Cijena = Convert.ToDecimal(textBoxCijena.Text);
             
                var korisnici = await _apiServiceKorisnici.Get<List<Model.Korisnici>>(null);
                var korisnik = korisnici.FirstOrDefault(x => x.KorisnickoIme == APIService.Username);
                if(korisnik!=null)
                {
                    req.KorisnikID = korisnik.KorisnikID;
                }
                if (_id.HasValue)
                {
                    try
                    {
                        await _apiService.Update<Model.Projekcije>(_id.Value, req);
                        MessageBox.Show("Uspješno sačuvani podaci");
                        this.Close();
                    }

                    catch (Exception)
                    {
                        DialogResult r = MessageBox.Show("Nemate pravo pristupa!");
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
                        await _apiService.Insert<Model.Projekcije>(req);
                        MessageBox.Show("Uspješno sačuvani podaci!");
                        this.Close();
                    }

                    catch (Exception)
                    {
                        DialogResult r = MessageBox.Show("Nemate pravo pristupa!");
                        if (r == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Operacija nije uspjela!");
                this.Close();
            }

        }

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCijena.Text))
            {
                errorProvider1.SetError(textBoxCijena, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(textBoxCijena.Text, @"^[0-9]+$"))
            {
                errorProvider1.SetError(textBoxCijena, Properties.Resources.NeispravanFormat);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBoxCijena, null);
            }
        }
    }
 }

