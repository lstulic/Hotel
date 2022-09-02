namespace TVP_Projekat_Lazar_Stulic_RT_1_20
{
    partial class FormGosti
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
            this.lbGosti = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbDodaj = new System.Windows.Forms.RadioButton();
            this.rbIzmeni = new System.Windows.Forms.RadioButton();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbGosti
            // 
            this.lbGosti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGosti.FormattingEnabled = true;
            this.lbGosti.HorizontalScrollbar = true;
            this.lbGosti.ItemHeight = 18;
            this.lbGosti.Location = new System.Drawing.Point(12, 12);
            this.lbGosti.Name = "lbGosti";
            this.lbGosti.ScrollAlwaysVisible = true;
            this.lbGosti.Size = new System.Drawing.Size(628, 292);
            this.lbGosti.TabIndex = 0;
            this.lbGosti.SelectedIndexChanged += new System.EventHandler(this.lbGosti_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(730, 57);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(192, 20);
            this.txtIme.TabIndex = 2;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(730, 83);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(192, 20);
            this.txtPrezime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum rodjenja";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(730, 135);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(192, 20);
            this.txtTelefon.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(646, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefon";
            // 
            // rbDodaj
            // 
            this.rbDodaj.AutoSize = true;
            this.rbDodaj.Checked = true;
            this.rbDodaj.Location = new System.Drawing.Point(649, 17);
            this.rbDodaj.Name = "rbDodaj";
            this.rbDodaj.Size = new System.Drawing.Size(53, 17);
            this.rbDodaj.TabIndex = 9;
            this.rbDodaj.TabStop = true;
            this.rbDodaj.Text = "Dodaj";
            this.rbDodaj.UseVisualStyleBackColor = true;
            this.rbDodaj.CheckedChanged += new System.EventHandler(this.rbDodaj_CheckedChanged);
            // 
            // rbIzmeni
            // 
            this.rbIzmeni.AutoSize = true;
            this.rbIzmeni.Location = new System.Drawing.Point(708, 17);
            this.rbIzmeni.Name = "rbIzmeni";
            this.rbIzmeni.Size = new System.Drawing.Size(55, 17);
            this.rbIzmeni.TabIndex = 10;
            this.rbIzmeni.Text = "Izmeni";
            this.rbIzmeni.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(647, 170);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(275, 34);
            this.btnDodaj.TabIndex = 11;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(647, 250);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(275, 34);
            this.btnObrisi.TabIndex = 12;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(647, 210);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(275, 34);
            this.btnIzmeni.TabIndex = 13;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(730, 109);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(192, 20);
            this.dtpDatum.TabIndex = 14;
            // 
            // FormGosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 311);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.rbIzmeni);
            this.Controls.Add(this.rbDodaj);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGosti);
            this.Name = "FormGosti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGosti";
            this.Load += new System.EventHandler(this.FormGosti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbGosti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbDodaj;
        private System.Windows.Forms.RadioButton rbIzmeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.DateTimePicker dtpDatum;
    }
}