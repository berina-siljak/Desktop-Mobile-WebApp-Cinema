namespace Kino.WinUI.Filmovi
{
    partial class frmFilmoviDetalji

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.txtNazivFilma = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtRežiser = new System.Windows.Forms.TextBox();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SnimiButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxZanrovi = new System.Windows.Forms.ComboBox();
            this.textBoxGlumci = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxGodina = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv filma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Režiser:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trajanje:";
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.BackColor = System.Drawing.Color.Moccasin;
            this.btnDodajSliku.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDodajSliku.FlatAppearance.BorderSize = 0;
            this.btnDodajSliku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajSliku.Location = new System.Drawing.Point(330, 323);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(89, 22);
            this.btnDodajSliku.TabIndex = 4;
            this.btnDodajSliku.Text = "Dodaj";
            this.btnDodajSliku.UseVisualStyleBackColor = false;
            this.btnDodajSliku.Click += new System.EventHandler(this.BtnDodajSliku_Click);
            // 
            // txtNazivFilma
            // 
            this.txtNazivFilma.Location = new System.Drawing.Point(116, 45);
            this.txtNazivFilma.Name = "txtNazivFilma";
            this.txtNazivFilma.Size = new System.Drawing.Size(199, 20);
            this.txtNazivFilma.TabIndex = 5;
            this.txtNazivFilma.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(116, 81);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(199, 20);
            this.txtOpis.TabIndex = 6;
            this.txtOpis.Validating += new System.ComponentModel.CancelEventHandler(this.txtOpis_Validating);
            // 
            // txtRežiser
            // 
            this.txtRežiser.Location = new System.Drawing.Point(116, 120);
            this.txtRežiser.Name = "txtRežiser";
            this.txtRežiser.Size = new System.Drawing.Size(199, 20);
            this.txtRežiser.TabIndex = 7;
            this.txtRežiser.Validating += new System.ComponentModel.CancelEventHandler(this.txtReziser_Validating);
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Location = new System.Drawing.Point(116, 237);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(199, 20);
            this.txtTrajanje.TabIndex = 8;
            this.txtTrajanje.Validating += new System.ComponentModel.CancelEventHandler(this.txtTrajanje_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(533, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Slika:";
            // 
            // SnimiButton
            // 
            this.SnimiButton.BackColor = System.Drawing.Color.Orange;
            this.SnimiButton.FlatAppearance.BorderSize = 0;
            this.SnimiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SnimiButton.Location = new System.Drawing.Point(594, 576);
            this.SnimiButton.Name = "SnimiButton";
            this.SnimiButton.Size = new System.Drawing.Size(91, 23);
            this.SnimiButton.TabIndex = 12;
            this.SnimiButton.Text = "Snimi";
            this.SnimiButton.UseVisualStyleBackColor = false;
            this.SnimiButton.Click += new System.EventHandler(this.SnimiButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(116, 325);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(199, 20);
            this.txtSlika.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Žanr:";
            // 
            // comboBoxZanrovi
            // 
            this.comboBoxZanrovi.ForeColor = System.Drawing.Color.Black;
            this.comboBoxZanrovi.FormattingEnabled = true;
            this.comboBoxZanrovi.Location = new System.Drawing.Point(116, 281);
            this.comboBoxZanrovi.Name = "comboBoxZanrovi";
            this.comboBoxZanrovi.Size = new System.Drawing.Size(199, 21);
            this.comboBoxZanrovi.TabIndex = 15;
            // 
            // textBoxGlumci
            // 
            this.textBoxGlumci.Location = new System.Drawing.Point(116, 159);
            this.textBoxGlumci.Name = "textBoxGlumci";
            this.textBoxGlumci.Size = new System.Drawing.Size(199, 20);
            this.textBoxGlumci.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Glumci";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Godina";
            // 
            // textBoxGodina
            // 
            this.textBoxGodina.Location = new System.Drawing.Point(116, 196);
            this.textBoxGodina.Name = "textBoxGodina";
            this.textBoxGodina.Size = new System.Drawing.Size(199, 20);
            this.textBoxGodina.TabIndex = 19;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmFilmoviDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(783, 652);
            this.Controls.Add(this.textBoxGodina);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxGlumci);
            this.Controls.Add(this.comboBoxZanrovi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.SnimiButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTrajanje);
            this.Controls.Add(this.txtRežiser);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtNazivFilma);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFilmoviDetalji";
            this.Text = "frmFilmoviDetalji";
            this.Load += new System.EventHandler(this.FrmFilmovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.TextBox txtNazivFilma;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtRežiser;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SnimiButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxZanrovi;
        private System.Windows.Forms.TextBox textBoxGlumci;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxGodina;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}