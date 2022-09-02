namespace TVP_Projekat_Lazar_Stulic_RT_1_20
{
    partial class FormSobe
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
            this.txtPopust = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrojKreveta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrojSobe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSobe = new System.Windows.Forms.ListBox();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinDana = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(649, 250);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(273, 34);
            this.btnIzmeni.TabIndex = 27;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(649, 290);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(273, 34);
            this.btnObrisi.TabIndex = 26;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(649, 210);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(273, 34);
            this.btnDodaj.TabIndex = 25;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // rbIzmeni
            // 
            this.rbIzmeni.AutoSize = true;
            this.rbIzmeni.Location = new System.Drawing.Point(708, 13);
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
            this.rbDodaj.Location = new System.Drawing.Point(649, 13);
            this.rbDodaj.Name = "rbDodaj";
            this.rbDodaj.Size = new System.Drawing.Size(53, 17);
            this.rbDodaj.TabIndex = 23;
            this.rbDodaj.TabStop = true;
            this.rbDodaj.Text = "Dodaj";
            this.rbDodaj.UseVisualStyleBackColor = true;
            this.rbDodaj.CheckedChanged += new System.EventHandler(this.rbDodaj_CheckedChanged);
            // 
            // txtPopust
            // 
            this.txtPopust.Location = new System.Drawing.Point(730, 158);
            this.txtPopust.Name = "txtPopust";
            this.txtPopust.Size = new System.Drawing.Size(192, 20);
            this.txtPopust.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(646, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Popust";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tip sobe";
            // 
            // txtBrojKreveta
            // 
            this.txtBrojKreveta.Location = new System.Drawing.Point(730, 79);
            this.txtBrojKreveta.Name = "txtBrojKreveta";
            this.txtBrojKreveta.Size = new System.Drawing.Size(192, 20);
            this.txtBrojKreveta.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Broj kreveta";
            // 
            // txtBrojSobe
            // 
            this.txtBrojSobe.Location = new System.Drawing.Point(730, 53);
            this.txtBrojSobe.Name = "txtBrojSobe";
            this.txtBrojSobe.Size = new System.Drawing.Size(192, 20);
            this.txtBrojSobe.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Broj sobe";
            // 
            // lbSobe
            // 
            this.lbSobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSobe.FormattingEnabled = true;
            this.lbSobe.HorizontalScrollbar = true;
            this.lbSobe.ItemHeight = 18;
            this.lbSobe.Location = new System.Drawing.Point(12, 12);
            this.lbSobe.Name = "lbSobe";
            this.lbSobe.ScrollAlwaysVisible = true;
            this.lbSobe.Size = new System.Drawing.Size(628, 310);
            this.lbSobe.TabIndex = 14;
            this.lbSobe.SelectedIndexChanged += new System.EventHandler(this.lbSobe_SelectedIndexChanged);
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Location = new System.Drawing.Point(730, 105);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(192, 21);
            this.cbTip.TabIndex = 28;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(730, 132);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(191, 20);
            this.txtCena.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(646, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Minimalno dana";
            // 
            // txtMinDana
            // 
            this.txtMinDana.Location = new System.Drawing.Point(730, 184);
            this.txtMinDana.Name = "txtMinDana";
            this.txtMinDana.Size = new System.Drawing.Size(192, 20);
            this.txtMinDana.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(646, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Cena";
            // 
            // FormSobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 336);
            this.Controls.Add(this.txtMinDana);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTip);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.rbIzmeni);
            this.Controls.Add(this.rbDodaj);
            this.Controls.Add(this.txtPopust);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBrojKreveta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBrojSobe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSobe);
            this.Name = "FormSobe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSobe";
            this.Load += new System.EventHandler(this.FormSobe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.RadioButton rbIzmeni;
        private System.Windows.Forms.RadioButton rbDodaj;
        private System.Windows.Forms.TextBox txtPopust;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrojKreveta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrojSobe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbSobe;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMinDana;
        private System.Windows.Forms.Label label6;
    }
}