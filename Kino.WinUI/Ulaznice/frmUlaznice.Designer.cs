namespace Kino.WinUI.Ulaznice
{
    partial class frmUlaznice
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
            this.dgvUlaznice = new System.Windows.Forms.DataGridView();
            this.UlaznicaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Projekcija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sjediste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxKupci = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUlaznice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUlaznice
            // 
            this.dgvUlaznice.AllowUserToAddRows = false;
            this.dgvUlaznice.AllowUserToDeleteRows = false;
            this.dgvUlaznice.BackgroundColor = System.Drawing.Color.White;
            this.dgvUlaznice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUlaznice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UlaznicaID,
            this.Datum,
            this.Sala,
            this.Projekcija,
            this.Sjediste,
            this.Cijena});
            this.dgvUlaznice.Location = new System.Drawing.Point(80, 184);
            this.dgvUlaznice.MultiSelect = false;
            this.dgvUlaznice.Name = "dgvUlaznice";
            this.dgvUlaznice.ReadOnly = true;
            this.dgvUlaznice.Size = new System.Drawing.Size(644, 198);
            this.dgvUlaznice.TabIndex = 0;
            // 
            // UlaznicaID
            // 
            this.UlaznicaID.DataPropertyName = "UlaznicaID";
            this.UlaznicaID.HeaderText = "UlaznicaID";
            this.UlaznicaID.Name = "UlaznicaID";
            this.UlaznicaID.ReadOnly = true;
            this.UlaznicaID.Visible = false;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Sala
            // 
            this.Sala.DataPropertyName = "Sala";
            this.Sala.HeaderText = "Sala";
            this.Sala.Name = "Sala";
            this.Sala.ReadOnly = true;
            // 
            // Projekcija
            // 
            this.Projekcija.DataPropertyName = "Projekcija";
            this.Projekcija.HeaderText = "Projekcija";
            this.Projekcija.Name = "Projekcija";
            this.Projekcija.ReadOnly = true;
            // 
            // Sjediste
            // 
            this.Sjediste.DataPropertyName = "OznakaSjedista";
            this.Sjediste.HeaderText = "Sjediste";
            this.Sjediste.Name = "Sjediste";
            this.Sjediste.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "CijenaSaPopustom";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // comboBoxKupci
            // 
            this.comboBoxKupci.FormattingEnabled = true;
            this.comboBoxKupci.Location = new System.Drawing.Point(80, 103);
            this.comboBoxKupci.Name = "comboBoxKupci";
            this.comboBoxKupci.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKupci.TabIndex = 1;
            this.comboBoxKupci.SelectedIndexChanged += new System.EventHandler(this.ComboBoxKupci_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odaberite kupca:";
            // 
            // frmUlaznice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxKupci);
            this.Controls.Add(this.dgvUlaznice);
            this.Name = "frmUlaznice";
            this.Text = "frmUlaznice";
            this.Load += new System.EventHandler(this.FrmUlaznice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUlaznice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUlaznice;
        private System.Windows.Forms.ComboBox comboBoxKupci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UlaznicaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Projekcija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sjediste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
    }
}