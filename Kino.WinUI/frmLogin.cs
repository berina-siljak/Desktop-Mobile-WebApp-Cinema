using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino.WinUI
{
    public partial class frmLogin : Form
    {
        APIService _service = new APIService("Korisnici");

        public frmLogin()
        {
            InitializeComponent();
            txtPassword.Text = "test";
            txtUsername.Text = "desktop";
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            APIService.Username = txtUsername.Text;
            APIService.Password = txtPassword.Text;
            try
            {
                await _service.Get<dynamic>(null);
                Model.Korisnici korisnik = null;
                List<Model.Korisnici> lista = await _service.Get<List<Model.Korisnici>>(null);
                korisnik = lista.FirstOrDefault(x => x.KorisnickoIme == APIService.Username);
                if (korisnik != null)
                {
                    frmIndex frm = new frmIndex();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nemate Pravo Pristupa!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
