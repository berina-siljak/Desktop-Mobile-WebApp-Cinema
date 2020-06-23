namespace Kino.WinUI.Projekcije
{
    partial class frmProjekcije
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
            this.dgvProjekcije = new System.Windows.Forms.DataGridView();
            this.ProjekcijaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Film = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbFilmovi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.slikaFilma = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjekcije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slikaFilma)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProjekcije
            // 
            this.dgvProjekcije.AllowUserToAddRows = false;
            this.dgvProjekcije.AllowUserToDeleteRows = false;
            this.dgvProjekcije.BackgroundColor = System.Drawing.Color.White;
            this.dgvProjekcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjekcije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjekcijaID,
            this.Datum,
            this.Cijena,
            this.Film,
            this.Sala});
            this.dgvProjekcije.Location = new System.Drawing.Point(55, 278);
            this.dgvProjekcije.MultiSelect = false;
            this.dgvProjekcije.Name = "dgvProjekcije";
            this.dgvProjekcije.ReadOnly = true;
            this.dgvProjekcije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjekcije.Size = new System.Drawing.Size(445, 150);
            this.dgvProjekcije.TabIndex = 0;
            this.dgvProjekcije.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvProjekcije_MouseDoubleClick);
            // 
            // ProjekcijaID
            // 
            this.ProjekcijaID.DataPropertyName = "ProjekcijaID";
            this.ProjekcijaID.HeaderText = "ProjekcijaID";
            this.ProjekcijaID.Name = "ProjekcijaID";
            this.ProjekcijaID.ReadOnly = true;
            this.ProjekcijaID.Visible = false;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // Film
            // 
            this.Film.DataPropertyName = "Film";
            this.Film.HeaderText = "Film";
            this.Film.Name = "Film";
            this.Film.ReadOnly = true;
            // 
            // Sala
            // 
            this.Sala.DataPropertyName = "Sala";
            this.Sala.HeaderText = "Sala";
            this.Sala.Name = "Sala";
            this.Sala.ReadOnly = true;
            // 
            // cmbFilmovi
            // 
            this.cmbFilmovi.FormattingEnabled = true;
            this.cmbFilmovi.Location = new System.Drawing.Point(55, 70);
            this.cmbFilmovi.Name = "cmbFilmovi";
            this.cmbFilmovi.Size = new System.Drawing.Size(194, 21);
            this.cmbFilmovi.TabIndex = 3;
            this.cmbFilmovi.SelectionChangeCommitted += new System.EventHandler(this.CmbFilmovi_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Odaberite film:";
            // 
            // slikaFilma
            // 
            this.slikaFilma.Location = new System.Drawing.Point(301, 26);
            this.slikaFilma.Name = "slikaFilma";
            this.slikaFilma.Size = new System.Drawing.Size(199, 224);
            this.slikaFilma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slikaFilma.TabIndex = 10;
            this.slikaFilma.TabStop = false;
            // 
            // frmProjekcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.slikaFilma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFilmovi);
            this.Controls.Add(this.dgvProjekcije);
            this.Name = "frmProjekcije";
            this.Text = "frmProjekcije";
            this.Load += new System.EventHandler(this.FrmProjekcije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjekcije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slikaFilma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProjekcije;
        private System.Windows.Forms.ComboBox cmbFilmovi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox slikaFilma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjekcijaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Film;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sala;
    }
}