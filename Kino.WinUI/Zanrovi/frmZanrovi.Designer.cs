namespace Kino.WinUI.Zanrovi
{
    partial class frmZanrovi
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
            this.dgvZanrovi = new System.Windows.Forms.DataGridView();
            this.ZanrID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.SnimiZanr = new System.Windows.Forms.Button();
            this.txtNazivZanra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZanrovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZanrovi
            // 
            this.dgvZanrovi.AllowUserToAddRows = false;
            this.dgvZanrovi.AllowUserToDeleteRows = false;
            this.dgvZanrovi.BackgroundColor = System.Drawing.Color.White;
            this.dgvZanrovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZanrovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ZanrID,
            this.Naziv});
            this.dgvZanrovi.Location = new System.Drawing.Point(37, 260);
            this.dgvZanrovi.MultiSelect = false;
            this.dgvZanrovi.Name = "dgvZanrovi";
            this.dgvZanrovi.ReadOnly = true;
            this.dgvZanrovi.Size = new System.Drawing.Size(331, 178);
            this.dgvZanrovi.TabIndex = 0;
            // 
            // ZanrID
            // 
            this.ZanrID.HeaderText = "ZanrID";
            this.ZanrID.Name = "ZanrID";
            this.ZanrID.ReadOnly = true;
            this.ZanrID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(202, 202);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.BtnPrikazi_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(37, 205);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(142, 20);
            this.txtPretraga.TabIndex = 2;
            // 
            // SnimiZanr
            // 
            this.SnimiZanr.Location = new System.Drawing.Point(104, 105);
            this.SnimiZanr.Name = "SnimiZanr";
            this.SnimiZanr.Size = new System.Drawing.Size(75, 23);
            this.SnimiZanr.TabIndex = 3;
            this.SnimiZanr.Text = "Snimi";
            this.SnimiZanr.UseVisualStyleBackColor = true;
            this.SnimiZanr.Click += new System.EventHandler(this.SnimiZanr_Click);
            // 
            // txtNazivZanra
            // 
            this.txtNazivZanra.Location = new System.Drawing.Point(25, 64);
            this.txtNazivZanra.Name = "txtNazivZanra";
            this.txtNazivZanra.Size = new System.Drawing.Size(154, 20);
            this.txtNazivZanra.TabIndex = 4;
            this.txtNazivZanra.Validating += new System.ComponentModel.CancelEventHandler(this.txtNazivZanra_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naziv žanra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "DODAJ ŽANR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pretraga:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmZanrovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 477);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNazivZanra);
            this.Controls.Add(this.SnimiZanr);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dgvZanrovi);
            this.Name = "frmZanrovi";
            this.Text = "frmZanrovi";
            this.Load += new System.EventHandler(this.FrmZanrovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZanrovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZanrovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZanrID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button SnimiZanr;
        private System.Windows.Forms.TextBox txtNazivZanra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}