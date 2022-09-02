namespace TVP_Projekat_Lazar_Stulic_RT_1_20
{
    partial class FormRezervacije
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
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoba = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRezervacije = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(649, 256);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(273, 34);
            this.btnIzmeni.TabIndex = 43;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(649, 296);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(273, 34);
            this.btnObrisi.TabIndex = 42;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(649, 216);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(273, 34);
            this.btnDodaj.TabIndex = 41;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // rbIzmeni
            // 
            this.rbIzmeni.AutoSize = true;
            this.rbIzmeni.Location = new System.Drawing.Point(708, 11);
            this.rbIzmeni.Name = "rbIzmeni";
            this.rbIzmeni.Size = new System.Drawing.Size(55, 17);
            this.rbIzmeni.TabIndex = 40;
            this.rbIzmeni.Text = "Izmeni";
            this.rbIzmeni.UseVisualStyleBackColor = true;
            // 
            // rbDodaj
            // 
            this.rbDodaj.AutoSize = true;
            this.rbDodaj.Checked = true;
            this.rbDodaj.Location = new System.Drawing.Point(649, 11);
            this.rbDodaj.Name = "rbDodaj";
            this.rbDodaj.Size = new System.Drawing.Size(53, 17);
            this.rbDodaj.TabIndex = 39;
            this.rbDodaj.TabStop = true;
            this.rbDodaj.Text = "Dodaj";
            this.rbDodaj.UseVisualStyleBackColor = true;
            this.rbDodaj.CheckedChanged += new System.EventHandler(this.rbDodaj_CheckedChanged);
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(730, 155);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(192, 20);
            this.txtCena.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(646, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Datum do";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Datum od";
            // 
            // txtGost
            // 
            this.txtGost.Location = new System.Drawing.Point(730, 77);
            this.txtGost.Name = "txtGost";
            this.txtGost.Size = new System.Drawing.Size(192, 20);
            this.txtGost.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "ID Gosta";
            // 
            // txtSoba
            // 
            this.txtSoba.Location = new System.Drawing.Point(730, 51);
            this.txtSoba.Name = "txtSoba";
            this.txtSoba.Size = new System.Drawing.Size(192, 20);
            this.txtSoba.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID Sobe";
            // 
            // lbRezervacije
            // 
            this.lbRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRezervacije.FormattingEnabled = true;
            this.lbRezervacije.HorizontalScrollbar = true;
            this.lbRezervacije.ItemHeight = 18;
            this.lbRezervacije.Location = new System.Drawing.Point(12, 12);
            this.lbRezervacije.Name = "lbRezervacije";
            this.lbRezervacije.ScrollAlwaysVisible = true;
            this.lbRezervacije.Size = new System.Drawing.Size(628, 310);
            this.lbRezervacije.TabIndex = 31;
            this.lbRezervacije.SelectedIndexChanged += new System.EventHandler(this.lbRezervacije_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(646, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Ukupna cena";
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(730, 103);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(192, 20);
            this.dtpOd.TabIndex = 47;
            // 
            // dtpDo
            // 
            this.dtpDo.Location = new System.Drawing.Point(730, 129);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(192, 20);
            this.dtpDo.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(646, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Tip rezervacije";
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Location = new System.Drawing.Point(730, 181);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(192, 21);
            this.cbTip.TabIndex = 51;
            // 
            // FormRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 346);
            this.Controls.Add(this.cbTip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDo);
            this.Controls.Add(this.dtpOd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.rbIzmeni);
            this.Controls.Add(this.rbDodaj);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoba);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbRezervacije);
            this.Name = "FormRezervacije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRezervacije";
            this.Load += new System.EventHandler(this.FormRezervacije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.RadioButton rbIzmeni;
        private System.Windows.Forms.RadioButton rbDodaj;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbRezervacije;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTip;
    }
}