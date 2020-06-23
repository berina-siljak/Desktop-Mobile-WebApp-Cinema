namespace Kino.WinUI.Izvjestaji
{
    partial class frmIzvjestajiUlaznica
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
            this.comboGodina = new System.Windows.Forms.ComboBox();
            this.dgvIzvjestaj = new System.Windows.Forms.DataGridView();
            this.Film = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zanr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojUlaznica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zarada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUkupnaZarada = new System.Windows.Forms.TextBox();
            this.buttonPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestaj)).BeginInit();
            this.SuspendLayout();
            // 
            // comboGodina
            // 
            this.comboGodina.FormattingEnabled = true;
            this.comboGodina.Location = new System.Drawing.Point(229, 66);
            this.comboGodina.Name = "comboGodina";
            this.comboGodina.Size = new System.Drawing.Size(121, 21);
            this.comboGodina.TabIndex = 0;
            this.comboGodina.SelectedIndexChanged += new System.EventHandler(this.ComboGodina_SelectedIndexChanged);
            // 
            // dgvIzvjestaj
            // 
            this.dgvIzvjestaj.AllowUserToAddRows = false;
            this.dgvIzvjestaj.AllowUserToDeleteRows = false;
            this.dgvIzvjestaj.BackgroundColor = System.Drawing.Color.White;
            this.dgvIzvjestaj.CausesValidation = false;
            this.dgvIzvjestaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvjestaj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Film,
            this.Zanr,
            this.BrojUlaznica,
            this.Zarada});
            this.dgvIzvjestaj.Location = new System.Drawing.Point(229, 134);
            this.dgvIzvjestaj.Name = "dgvIzvjestaj";
            this.dgvIzvjestaj.ReadOnly = true;
            this.dgvIzvjestaj.Size = new System.Drawing.Size(446, 206);
            this.dgvIzvjestaj.TabIndex = 1;
            // 
            // Film
            // 
            this.Film.DataPropertyName = "Film";
            this.Film.HeaderText = "Film";
            this.Film.Name = "Film";
            this.Film.ReadOnly = true;
            // 
            // Zanr
            // 
            this.Zanr.DataPropertyName = "Zanr";
            this.Zanr.HeaderText = "Zanr";
            this.Zanr.Name = "Zanr";
            this.Zanr.ReadOnly = true;
            // 
            // BrojUlaznica
            // 
            this.BrojUlaznica.DataPropertyName = "BrojProdanihUlaznica";
            this.BrojUlaznica.HeaderText = "BrojUlaznica";
            this.BrojUlaznica.Name = "BrojUlaznica";
            this.BrojUlaznica.ReadOnly = true;
            // 
            // Zarada
            // 
            this.Zarada.DataPropertyName = "Zarada";
            this.Zarada.HeaderText = "Zarada";
            this.Zarada.Name = "Zarada";
            this.Zarada.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ukupna zarada:";
            // 
            // txtUkupnaZarada
            // 
            this.txtUkupnaZarada.Location = new System.Drawing.Point(334, 390);
            this.txtUkupnaZarada.Name = "txtUkupnaZarada";
            this.txtUkupnaZarada.Size = new System.Drawing.Size(100, 20);
            this.txtUkupnaZarada.TabIndex = 3;
            // 
            // buttonPdf
            // 
            this.buttonPdf.Location = new System.Drawing.Point(600, 390);
            this.buttonPdf.Name = "buttonPdf";
            this.buttonPdf.Size = new System.Drawing.Size(75, 23);
            this.buttonPdf.TabIndex = 4;
            this.buttonPdf.Text = "PDF";
            this.buttonPdf.UseVisualStyleBackColor = true;
            this.buttonPdf.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonPdf_MouseClick);
            // 
            // frmIzvjestajiUlaznica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 450);
            this.Controls.Add(this.buttonPdf);
            this.Controls.Add(this.txtUkupnaZarada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIzvjestaj);
            this.Controls.Add(this.comboGodina);
            this.Name = "frmIzvjestajiUlaznica";
            this.Text = "frmIzvjestajiUlaznica";
            this.Load += new System.EventHandler(this.FrmIzvjestajiUlaznica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboGodina;
        private System.Windows.Forms.DataGridView dgvIzvjestaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Film;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zanr;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojUlaznica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zarada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUkupnaZarada;
        private System.Windows.Forms.Button buttonPdf;
    }
}