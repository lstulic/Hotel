namespace TVP_Projekat_Lazar_Stulic_RT_1_20
{
    partial class FormKorisnici
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
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.rbIzmeni = new System.Windows.Forms.RadioButton();
            this.rbDodaj = new System.Windows.Forms.RadioButton();
            this.txtKorisnicko = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbKorisnici = new System.Windows.Forms.ListBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbVrsta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(647, 225);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(275, 34);
            this.btnIzmeni.TabIndex = 27;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(647, 265);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(275, 34);
            this.btnObrisi.TabIndex = 26;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(647, 185);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(275, 34);
            this.btnDodaj.TabIndex = 25;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // rbIzmeni
            // 
            this.rbIzmeni.AutoSize = true;
            this.rbIzmeni.Location = new System.Drawing.Point(708, 10);
            this.rbIzmeni.Name = "rbIzmeni";
            this.rbIzmeni.Size = new System.Drawing.Size(55, 17);
            this.rbIzmeni.TabIndex = 24;
            this.rbIzmeni.Text = "Izmeni";
            this.rbIzmeni.UseVisualStyleBackColor = true;
            // 
            // rbDodaj
            // 
            this.rbDodaj.AutoSize = true;
            this.rbDodaj.Checked = true;
            this.rbDodaj.Location = new System.Drawing.Point(649, 10);
            this.rbDodaj.Name = "rbDodaj";
            this.rbDodaj.Size = new System.Drawing.Size(53, 17);
            this.rbDodaj.TabIndex = 23;
            this.rbDodaj.TabStop = true;
            this.rbDodaj.Text = "Dodaj";
            this.rbDodaj.UseVisualStyleBackColor = true;
            this.rbDodaj.CheckedChanged += new System.EventHandler(this.rbDodaj_CheckedChanged);
            // 
            // txtKorisnicko
            // 
            this.txtKorisnicko.Location = new System.Drawing.Point(730, 102);
            this.txtKorisnicko.Name = "txtKorisnicko";
            this.txtKorisnicko.Size = new System.Drawing.Size(192, 20);
            this.txtKorisnicko.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(646, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Lozinka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Korisnicko ime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(730, 76);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(192, 20);
            this.txtPrezime.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Prezime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(730, 50);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(192, 20);
            this.txtIme.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ime";
            // 
            // lbKorisnici
            // 
            this.lbKorisnici.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKorisnici.FormattingEnabled = true;
            this.lbKorisnici.HorizontalScrollbar = true;
            this.lbKorisnici.ItemHeight = 18;
            this.lbKorisnici.Location = new System.Drawing.Point(15, 12);
            this.lbKorisnici.Name = "lbKorisnici";
            this.lbKorisnici.ScrollAlwaysVisible = true;
            this.lbKorisnici.Size = new System.Drawing.Size(628, 292);
            this.lbKorisnici.TabIndex = 15;
            this.lbKorisnici.SelectedIndexChanged += new System.EventHandler(this.lbKorisnici_SelectedIndexChanged);
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(730, 128);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(192, 20);
            this.txtLozinka.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(647, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Vrsta korisnika";
            // 
            // cbVrsta
            // 
            this.cbVrsta.FormattingEnabled = true;
            this.cbVrsta.Location = new System.Drawing.Point(730, 154);
            this.cbVrsta.Name = "cbVrsta";
            this.cbVrsta.Size = new System.Drawing.Size(191, 21);
            this.cbVrsta.TabIndex = 31;
            // 
            // FormKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 311);
            this.Controls.Add(this.cbVrsta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.rbIzmeni);
            this.Controls.Add(this.rbDodaj);
            this.Controls.Add(this.txtKorisnicko);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbKorisnici);
            this.Name = "FormKorisnici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKorisnici";
            this.Load += new System.EventHandler(this.FormKorisnici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.RadioButton rbIzmeni;
        private System.Windows.Forms.RadioButton rbDodaj;
        private System.Windows.Forms.TextBox txtKorisnicko;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbKorisnici;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbVrsta;
    }
}