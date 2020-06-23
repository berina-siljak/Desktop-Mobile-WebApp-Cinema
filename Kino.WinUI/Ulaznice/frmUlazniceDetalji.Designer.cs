namespace Kino.WinUI.Ulaznice
{
    partial class frmUlazniceDetalji
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1Kupci = new System.Windows.Forms.ComboBox();
            this.comboBox3Projekcije = new System.Windows.Forms.ComboBox();
            this.SnimiBtn = new System.Windows.Forms.Button();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.dtpVrijeme = new System.Windows.Forms.DateTimePicker();
            this.lblNazivFilma = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.slikaFilma = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFilmovi = new System.Windows.Forms.ComboBox();
            this.lblZanr = new System.Windows.Forms.Label();
            this.lblReditelj = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.textBoxPopust = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.slikaFilma)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1Kupci
            // 
            this.comboBox1Kupci.FormattingEnabled = true;
            this.comboBox1Kupci.Location = new System.Drawing.Point(45, 147);
            this.comboBox1Kupci.Name = "comboBox1Kupci";
            this.comboBox1Kupci.Size = new System.Drawing.Size(200, 21);
            this.comboBox1Kupci.TabIndex = 0;
            // 
            // comboBox3Projekcije
            // 
            this.comboBox3Projekcije.FormattingEnabled = true;
            this.comboBox3Projekcije.Location = new System.Drawing.Point(45, 91);
            this.comboBox3Projekcije.Name = "comboBox3Projekcije";
            this.comboBox3Projekcije.Size = new System.Drawing.Size(200, 21);
            this.comboBox3Projekcije.TabIndex = 2;
            this.comboBox3Projekcije.SelectionChangeCommitted += new System.EventHandler(this.ComboBox3Projekcije_SelectionChangeCommitted);
            // 
            // SnimiBtn
            // 
            this.SnimiBtn.Location = new System.Drawing.Point(676, 422);
            this.SnimiBtn.Name = "SnimiBtn";
            this.SnimiBtn.Size = new System.Drawing.Size(84, 20);
            this.SnimiBtn.TabIndex = 3;
            this.SnimiBtn.Text = "Snimi";
            this.SnimiBtn.UseVisualStyleBackColor = true;
            this.SnimiBtn.Click += new System.EventHandler(this.SnimiBtn_Click);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(560, 304);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 4;
            // 
            // dtpVrijeme
            // 
            this.dtpVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVrijeme.Location = new System.Drawing.Point(560, 375);
            this.dtpVrijeme.Name = "dtpVrijeme";
            this.dtpVrijeme.Size = new System.Drawing.Size(200, 20);
            this.dtpVrijeme.TabIndex = 5;
            // 
            // lblNazivFilma
            // 
            this.lblNazivFilma.AutoSize = true;
            this.lblNazivFilma.Location = new System.Drawing.Point(459, 36);
            this.lblNazivFilma.Name = "lblNazivFilma";
            this.lblNazivFilma.Size = new System.Drawing.Size(0, 13);
            this.lblNazivFilma.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vrijeme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sjediste:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kupac:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Projekcije:";
            // 
            // slikaFilma
            // 
            this.slikaFilma.Location = new System.Drawing.Point(561, 12);
            this.slikaFilma.Name = "slikaFilma";
            this.slikaFilma.Size = new System.Drawing.Size(199, 224);
            this.slikaFilma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slikaFilma.TabIndex = 13;
            this.slikaFilma.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Odaberite film:";
            // 
            // cmbFilmovi
            // 
            this.cmbFilmovi.FormattingEnabled = true;
            this.cmbFilmovi.Location = new System.Drawing.Point(45, 36);
            this.cmbFilmovi.Name = "cmbFilmovi";
            this.cmbFilmovi.Size = new System.Drawing.Size(200, 21);
            this.cmbFilmovi.TabIndex = 11;
            this.cmbFilmovi.SelectionChangeCommitted += new System.EventHandler(this.CmbFilmovi_SelectionChangeCommitted);
            // 
            // lblZanr
            // 
            this.lblZanr.AutoSize = true;
            this.lblZanr.Location = new System.Drawing.Point(459, 65);
            this.lblZanr.Name = "lblZanr";
            this.lblZanr.Size = new System.Drawing.Size(0, 13);
            this.lblZanr.TabIndex = 14;
            // 
            // lblReditelj
            // 
            this.lblReditelj.AutoSize = true;
            this.lblReditelj.Location = new System.Drawing.Point(459, 99);
            this.lblReditelj.Name = "lblReditelj";
            this.lblReditelj.Size = new System.Drawing.Size(0, 13);
            this.lblReditelj.TabIndex = 15;
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(459, 131);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(0, 13);
            this.lblSala.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(46, 254);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(426, 188);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Datum:";
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(459, 159);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(0, 13);
            this.lblCijena.TabIndex = 20;
            // 
            // textBoxPopust
            // 
            this.textBoxPopust.Location = new System.Drawing.Point(45, 200);
            this.textBoxPopust.Name = "textBoxPopust";
            this.textBoxPopust.Size = new System.Drawing.Size(200, 20);
            this.textBoxPopust.TabIndex = 21;
            this.textBoxPopust.Text = "0";
            this.textBoxPopust.TextChanged += new System.EventHandler(this.TextBoxPopust_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Popust:";
            // 
            // frmUlazniceDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPopust);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.lblReditelj);
            this.Controls.Add(this.lblZanr);
            this.Controls.Add(this.slikaFilma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbFilmovi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNazivFilma);
            this.Controls.Add(this.dtpVrijeme);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.SnimiBtn);
            this.Controls.Add(this.comboBox3Projekcije);
            this.Controls.Add(this.comboBox1Kupci);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "frmUlazniceDetalji";
            this.Text = "frmUlazniceDetalji";
            this.Load += new System.EventHandler(this.FrmUlazniceDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slikaFilma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1Kupci;
        private System.Windows.Forms.ComboBox comboBox3Projekcije;
        private System.Windows.Forms.Button SnimiBtn;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.DateTimePicker dtpVrijeme;
        private System.Windows.Forms.Label lblNazivFilma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox slikaFilma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFilmovi;
        private System.Windows.Forms.Label lblZanr;
        private System.Windows.Forms.Label lblReditelj;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox textBoxPopust;
        private System.Windows.Forms.Label label7;
    }
}