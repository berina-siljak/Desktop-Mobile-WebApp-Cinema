using Kino.WinUI.Filmovi;
using Kino.WinUI.Izvjestaji;
using Kino.WinUI.Korisnici;
using Kino.WinUI.Kupci;
using Kino.WinUI.Projekcije;
using Kino.WinUI.Sale;
using Kino.WinUI.Sjedista;
using Kino.WinUI.Ulaznice;
using Kino.WinUI.Zanrovi;
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
    public partial class frmIndex : Form
    {
        public frmIndex()
        {
            InitializeComponent();
        }

     

        private void DodajKorisniciButton_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmKorisniciDetalji frm = new frmKorisniciDetalji();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
            frm.Show();
        }

    

        private void DodajFilmoviButton_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmFilmoviDetalji frm = new frmFilmoviDetalji();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
            frm.Show();
        }



        private void KorisniciButton_Click(object sender, EventArgs e)
        {

            panel.Controls.Clear();
            frmKorisnici frm = new frmKorisnici();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
            frm.Show();
        }

        private void FilmoviButton_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmFilmovi frm = new frmFilmovi();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
            frm.Show();

        }


        private void ZanroviButton_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmZanrovi frm = new frmZanrovi();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
            frm.Show();
        }


      

        private void SjedistaButton_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmSjedista frm = new frmSjedista();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
            frm.Show();
        }

        private void btnDodajProjekcije_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmProjekcijeDetalji frm = new frmProjekcijeDetalji();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
            frm.Show();
        }

        private void DodajProjekcijeButton_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmProjekcijeDetalji frm = new frmProjekcijeDetalji();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
            frm.Show();
        }

        private void ProjekcijeButton_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmProjekcije frm = new frmProjekcije();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
            frm.Show();
        }

        private void ZanroviButton_Click_1(object sender, EventArgs e)
        {

            panel.Controls.Clear();
            frmZanrovi frm = new frmZanrovi();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
            frm.Show();
        }

        private void SaleButton_Click_1(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmSale frm = new frmSale();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
            frm.Show();
        }

        private void DodajSaleButton_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmSaleDetalji frm = new frmSaleDetalji();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
            frm.Show();
        }

        private void UlazniceButton_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmUlaznice frm = new frmUlaznice();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
            frm.Show();

        }

        private void DodajUlazniceButton_Click_1(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmUlazniceDetalji frm = new frmUlazniceDetalji();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
            frm.Show();

        }

        private void IzvjestajiButton_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmIzvjestajiUlaznica frm = new frmIzvjestajiUlaznica();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
            frm.Show();
        }

        private void KupciButton_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmKupci frm = new frmKupci();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
            frm.Show();
        }

        private void DodajKupceButton_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmKupciDetalji frm = new frmKupciDetalji();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
            frm.Show();
        }

        private void BtnOdjava_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
