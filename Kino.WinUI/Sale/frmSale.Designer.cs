namespace Kino.WinUI.Sale
{
    partial class frmSale
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
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.SalaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oznaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojRedova = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojKolona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.txtSale = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSale
            // 
            this.dgvSale.AllowUserToAddRows = false;
            this.dgvSale.AllowUserToDeleteRows = false;
            this.dgvSale.BackgroundColor = System.Drawing.Color.White;
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalaID,
            this.Oznaka,
            this.BrojRedova,
            this.BrojKolona});
            this.dgvSale.Location = new System.Drawing.Point(112, 162);
            this.dgvSale.MultiSelect = false;
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.ReadOnly = true;
            this.dgvSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSale.Size = new System.Drawing.Size(575, 170);
            this.dgvSale.TabIndex = 0;
            this.dgvSale.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvSale_MouseDoubleClick);
            // 
            // SalaID
            // 
            this.SalaID.DataPropertyName = "SalaID";
            this.SalaID.HeaderText = "SalaID";
            this.SalaID.Name = "SalaID";
            this.SalaID.ReadOnly = true;
            this.SalaID.Visible = false;
            // 
            // Oznaka
            // 
            this.Oznaka.DataPropertyName = "Naziv";
            this.Oznaka.HeaderText = "Oznaka";
            this.Oznaka.Name = "Oznaka";
            this.Oznaka.ReadOnly = true;
            // 
            // BrojRedova
            // 
            this.BrojRedova.DataPropertyName = "BrojRedova";
            this.BrojRedova.HeaderText = "BrojRedova";
            this.BrojRedova.Name = "BrojRedova";
            this.BrojRedova.ReadOnly = true;
            // 
            // BrojKolona
            // 
            this.BrojKolona.DataPropertyName = "BrojKolona";
            this.BrojKolona.HeaderText = "BrojKolona";
            this.BrojKolona.Name = "BrojKolona";
            this.BrojKolona.ReadOnly = true;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrikazi.FlatAppearance.BorderSize = 0;
            this.btnPrikazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikazi.ForeColor = System.Drawing.Color.Black;
            this.btnPrikazi.Location = new System.Drawing.Point(400, 93);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.BtnPrikazi_Click);
            // 
            // txtSale
            // 
            this.txtSale.Location = new System.Drawing.Point(499, 95);
            this.txtSale.Name = "txtSale";
            this.txtSale.Size = new System.Drawing.Size(188, 20);
            this.txtSale.TabIndex = 2;
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSale);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dgvSale);
            this.DoubleBuffered = true;
            this.Name = "frmSale";
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.TextBox txtSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oznaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojRedova;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojKolona;
    }
}