using iTextSharp.text;
using iTextSharp.text.pdf;
using Kino.Model;
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

namespace Kino.WinUI.Izvjestaji
{
    public partial class frmIzvjestajiUlaznica : Form
    {
        public APIService _uplate = new APIService("Uplate");
        public APIService _ulaznice = new APIService("Ulaznice");
        public APIService _projekcije = new APIService("Projekcije");
        public APIService _filmovi = new APIService("Filmovi");
        public APIService _sale = new APIService("Sale");



        public frmIzvjestajiUlaznica()
        {
            InitializeComponent();
        }

        private void LoadGodine()
        {
            var gZ = DateTime.Now.Year;
            var gP = 2010;
            for (int i = gP; i <= gZ; i++)
            {
                comboGodina.Items.Add(i);
            }
            comboGodina.Text = "--Odaberite godinu--";
        }

        private void FrmIzvjestajiUlaznica_Load(object sender, EventArgs e)
        {
            LoadGodine();
            
        }
        private async Task LoadIzvjetaj(int idGodina)
        {
            var filmovi = await _filmovi.Get<List<Model.Filmovi>>(null);
            List<Model.Filmovi> listaFilmova = new List<Model.Filmovi>();
            List<Izvjestaj> lista = new List<Izvjestaj>();
            decimal UkupnaZarada = 0;

            foreach (var f in filmovi)
            {
                int brojUlaznica = 0;
                decimal zarada = 0;
                var projekcije = await _projekcije.Get<List<Model.Projekcije>>(new ProjekcijeSearchRequest() { FilmID = f.FilmID });
                foreach (var pr in projekcije)
                {
                    var ulaznice = await _ulaznice.Get<List<Model.Ulaznice>>(new UlazniceSearchRequest() { Godina = idGodina, ProjekcijaID = pr.ProjekcijaID });
                    foreach (var ul in ulaznice)
                    {
                        brojUlaznica++;
                            if (ul.ProjekcijaID==pr.ProjekcijaID)
                                zarada += ul.CijenaSaPopustom;
                       
                    }
                }
                UkupnaZarada += zarada;

                lista.Add(new Izvjestaj() { Film = f.Naziv, Zanr = f.NazivZanra, Zarada = zarada, BrojProdanihUlaznica = brojUlaznica });
            }
            dgvIzvjestaj.AutoGenerateColumns = false;
            dgvIzvjestaj.DataSource = lista;
            txtUkupnaZarada.Text = UkupnaZarada.ToString();

        }

        private async void ComboGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = comboGodina.SelectedItem;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadIzvjetaj(id);
            }
        }
        public void exportGridToPdf(DataGridView dgw, string fileName)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdfptable = new PdfPTable(dgw.Columns.Count);

            pdfptable.DefaultCell.Padding = 3;
            pdfptable.WidthPercentage = 100;
            pdfptable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfptable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            //header
            foreach (DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfptable.AddCell(cell);
            }


            //datarow
            foreach (DataGridViewRow row in dgw.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfptable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = fileName;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdfptable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }

        private void ButtonPdf_MouseClick(object sender, MouseEventArgs e)
        {
            exportGridToPdf(dgvIzvjestaj, "Izvjestaj");
        }
    }
}
        
