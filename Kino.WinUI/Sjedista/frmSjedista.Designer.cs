namespace Kino.WinUI.Sjedista
{
    partial class frmSjedista
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
            this.dgvSjedista = new System.Windows.Forms.DataGridView();
            this.SjedisteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OznakaReda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OznakaKolone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbSale = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSjedista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSjedista
            // 
            this.dgvSjedista.AllowUserToAddRows = false;
            this.dgvSjedista.AllowUserToDeleteRows = false;
            this.dgvSjedista.BackgroundColor = System.Drawing.Color.White;
            this.dgvSjedista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSjedista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SjedisteID,
            this.OznakaReda,
            this.OznakaKolone,
            this.Sala});
            this.dgvSjedista.Location = new System.Drawing.Point(108, 140);
            this.dgvSjedista.MultiSelect = false;
            this.dgvSjedista.Name = "dgvSjedista";
            this.dgvSjedista.ReadOnly = true;
            this.dgvSjedista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSjedista.Size = new System.Drawing.Size(344, 185);
            this.dgvSjedista.TabIndex = 0;
            // 
            // SjedisteID
            // 
            this.SjedisteID.DataPropertyName = "SjedisteID";
            this.SjedisteID.HeaderText = "SjedisteID";
            this.SjedisteID.Name = "SjedisteID";
            this.SjedisteID.ReadOnly = true;
            this.SjedisteID.Visible = false;
            // 
            // OznakaReda
            // 
            this.OznakaReda.DataPropertyName = "OznakaReda";
            this.OznakaReda.HeaderText = "OznakaReda";
            this.OznakaReda.Name = "OznakaReda";
            this.OznakaReda.ReadOnly = true;
            // 
            // OznakaKolone
            // 
            this.OznakaKolone.DataPropertyName = "OznakaKolone";
            this.OznakaKolone.HeaderText = "OznakaKolone";
            this.OznakaKolone.Name = "OznakaKolone";
            this.OznakaKolone.ReadOnly = true;
            // 
            // Sala
            // 
            this.Sala.DataPropertyName = "Sala";
            this.Sala.HeaderText = "Sala";
            this.Sala.Name = "Sala";
            this.Sala.ReadOnly = true;
            // 
            // cmbSale
            // 
            this.cmbSale.FormattingEnabled = true;
            this.cmbSale.Location = new System.Drawing.Point(108, 87);
            this.cmbSale.Name = "cmbSale";
            this.cmbSale.Size = new System.Drawing.Size(121, 21);
            this.cmbSale.TabIndex = 2;
            this.cmbSale.SelectedIndexChanged += new System.EventHandler(this.CmbSale_SelectedIndexChanged);
            // 
            // frmSjedista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(562, 387);
            this.Controls.Add(this.cmbSale);
            this.Controls.Add(this.dgvSjedista);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmSjedista";
            this.Text = "frmSjedista";
            this.Load += new System.EventHandler(this.FrmSjedista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSjedista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSjedista;
        private System.Windows.Forms.DataGridViewTextBoxColumn SjedisteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OznakaReda;
        private System.Windows.Forms.DataGridViewTextBoxColumn OznakaKolone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sala;
        private System.Windows.Forms.ComboBox cmbSale;
    }
}