namespace Kino.WinUI.Filmovi
{
    partial class frmFilmovi
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
            this.components = new System.ComponentModel.Container();
            this.txtFilmovi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvFilmovi = new System.Windows.Forms.DataGridView();
            this.FilmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivFilma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Režiser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Glumci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trajanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaIzdavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilmovi
            // 
            this.txtFilmovi.ForeColor = System.Drawing.Color.Black;
            this.txtFilmovi.Location = new System.Drawing.Point(586, 72);
            this.txtFilmovi.Name = "txtFilmovi";
            this.txtFilmovi.Size = new System.Drawing.Size(200, 20);
            this.txtFilmovi.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvFilmovi);
            this.groupBox1.Location = new System.Drawing.Point(28, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 466);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filmovi";
            // 
            // dgvFilmovi
            // 
            this.dgvFilmovi.AllowUserToAddRows = false;
            this.dgvFilmovi.AllowUserToDeleteRows = false;
            this.dgvFilmovi.BackgroundColor = System.Drawing.Color.White;
            this.dgvFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilmID,
            this.NazivFilma,
            this.Režiser,
            this.Glumci,
            this.Opis,
            this.Trajanje,
            this.GodinaIzdavanja,
            this.Slika});
            this.dgvFilmovi.Location = new System.Drawing.Point(6, 19);
            this.dgvFilmovi.MultiSelect = false;
            this.dgvFilmovi.Name = "dgvFilmovi";
            this.dgvFilmovi.ReadOnly = true;
            this.dgvFilmovi.RowTemplate.Height = 100;
            this.dgvFilmovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilmovi.Size = new System.Drawing.Size(745, 441);
            this.dgvFilmovi.TabIndex = 0;
            this.dgvFilmovi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvFilmovi_MouseDoubleClick);
            // 
            // FilmID
            // 
            this.FilmID.DataPropertyName = "FilmID";
            this.FilmID.HeaderText = "FilmID";
            this.FilmID.Name = "FilmID";
            this.FilmID.ReadOnly = true;
            this.FilmID.Visible = false;
            // 
            // NazivFilma
            // 
            this.NazivFilma.DataPropertyName = "Naziv";
            this.NazivFilma.HeaderText = "Naziv filma";
            this.NazivFilma.Name = "NazivFilma";
            this.NazivFilma.ReadOnly = true;
            // 
            // Režiser
            // 
            this.Režiser.DataPropertyName = "Reziser";
            this.Režiser.HeaderText = "Režiser";
            this.Režiser.Name = "Režiser";
            this.Režiser.ReadOnly = true;
            // 
            // Glumci
            // 
            this.Glumci.DataPropertyName = "Glumci";
            this.Glumci.HeaderText = "Glumci";
            this.Glumci.Name = "Glumci";
            this.Glumci.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // Trajanje
            // 
            this.Trajanje.DataPropertyName = "Trajanje";
            this.Trajanje.HeaderText = "Trajanje";
            this.Trajanje.Name = "Trajanje";
            this.Trajanje.ReadOnly = true;
            // 
            // GodinaIzdavanja
            // 
            this.GodinaIzdavanja.DataPropertyName = "GodinaIzdavanja";
            this.GodinaIzdavanja.HeaderText = "Godina";
            this.GodinaIzdavanja.Name = "GodinaIzdavanja";
            this.GodinaIzdavanja.ReadOnly = true;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            this.Slika.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Slika.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.Orange;
            this.btnPrikazi.FlatAppearance.BorderSize = 0;
            this.btnPrikazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikazi.Location = new System.Drawing.Point(477, 69);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 3;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.BtnPrikazi_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmFilmovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1002, 610);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFilmovi);
            this.Name = "frmFilmovi";
            this.Text = "frmFilmovi";
            this.Load += new System.EventHandler(this.FrmFilmovi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilmovi;
        private System.Windows.Forms.GroupBox groupBox1;
        //private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DataGridView dgvFilmovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivFilma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Režiser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Glumci;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trajanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaIzdavanja;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}