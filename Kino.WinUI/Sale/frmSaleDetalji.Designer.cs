namespace Kino.WinUI.Sale
{
    partial class frmSaleDetalji
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
            this.txtOznaka = new System.Windows.Forms.TextBox();
            this.txtBrojKolona = new System.Windows.Forms.TextBox();
            this.txtBrojRedova = new System.Windows.Forms.TextBox();
            this.dgvSale2 = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojRedova2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojKolona2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oznaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojKolona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojRedova = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOznaka
            // 
            this.txtOznaka.Location = new System.Drawing.Point(46, 57);
            this.txtOznaka.Name = "txtOznaka";
            this.txtOznaka.Size = new System.Drawing.Size(182, 20);
            this.txtOznaka.TabIndex = 0;
            this.txtOznaka.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // txtBrojKolona
            // 
            this.txtBrojKolona.Location = new System.Drawing.Point(46, 158);
            this.txtBrojKolona.Name = "txtBrojKolona";
            this.txtBrojKolona.Size = new System.Drawing.Size(182, 20);
            this.txtBrojKolona.TabIndex = 1;
            this.txtBrojKolona.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojKolona_Validating);
            // 
            // txtBrojRedova
            // 
            this.txtBrojRedova.Location = new System.Drawing.Point(46, 108);
            this.txtBrojRedova.Name = "txtBrojRedova";
            this.txtBrojRedova.Size = new System.Drawing.Size(182, 20);
            this.txtBrojRedova.TabIndex = 2;
            this.txtBrojRedova.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojRedova_Validating);
            // 
            // dgvSale2
            // 
            this.dgvSale2.AllowUserToAddRows = false;
            this.dgvSale2.AllowUserToDeleteRows = false;
            this.dgvSale2.BackgroundColor = System.Drawing.Color.White;
            this.dgvSale2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.BrojRedova2,
            this.BrojKolona2});
            this.dgvSale2.Location = new System.Drawing.Point(46, 250);
            this.dgvSale2.Name = "dgvSale2";
            this.dgvSale2.ReadOnly = true;
            this.dgvSale2.Size = new System.Drawing.Size(345, 188);
            this.dgvSale2.TabIndex = 8;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // BrojRedova2
            // 
            this.BrojRedova2.DataPropertyName = "BrojRedova";
            this.BrojRedova2.HeaderText = "BrojRedova";
            this.BrojRedova2.Name = "BrojRedova2";
            this.BrojRedova2.ReadOnly = true;
            // 
            // BrojKolona2
            // 
            this.BrojKolona2.DataPropertyName = "BrojKolona";
            this.BrojKolona2.HeaderText = "BrojKolona";
            this.BrojKolona2.Name = "BrojKolona2";
            this.BrojKolona2.ReadOnly = true;
            // 
            // Oznaka
            // 
            this.Oznaka.DataPropertyName = "Naziv";
            this.Oznaka.HeaderText = "Oznaka";
            this.Oznaka.Name = "Oznaka";
            this.Oznaka.ReadOnly = true;
            // 
            // BrojKolona
            // 
            this.BrojKolona.DataPropertyName = "BrojKolona";
            this.BrojKolona.HeaderText = "BrojKolona";
            this.BrojKolona.Name = "BrojKolona";
            this.BrojKolona.ReadOnly = true;
            // 
            // BrojRedova
            // 
            this.BrojRedova.DataPropertyName = "BrojRedova";
            this.BrojRedova.HeaderText = "BrojRedova";
            this.BrojRedova.Name = "BrojRedova";
            this.BrojRedova.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv sale:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Broj kolona:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Broj redova:";
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.Orange;
            this.btnSnimi.FlatAppearance.BorderSize = 0;
            this.btnSnimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnimi.Location = new System.Drawing.Point(276, 155);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(75, 23);
            this.btnSnimi.TabIndex = 7;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.BtnSnimi_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "/kod dodavanja sala, automatski se dodaju i sjedišta za tu salu/";
            // 
            // frmSaleDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(519, 494);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSale2);
            this.Controls.Add(this.txtBrojRedova);
            this.Controls.Add(this.txtBrojKolona);
            this.Controls.Add(this.txtOznaka);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmSaleDetalji";
            this.Text = "frmSaleDetalji";
            this.Load += new System.EventHandler(this.FrmSaleDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOznaka;
        private System.Windows.Forms.TextBox txtBrojKolona;
        private System.Windows.Forms.TextBox txtBrojRedova;
        private System.Windows.Forms.DataGridView dgvSale2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oznaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojKolona;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojRedova;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojRedova2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojKolona2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
    }
}