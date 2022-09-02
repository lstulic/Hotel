namespace TVP_Projekat_Lazar_Stulic_RT_1_20
{
    partial class FormDodajRezervaciju
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
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbGosti = new System.Windows.Forms.ListBox();
            this.lbSobe = new System.Windows.Forms.ListBox();
            this.rbNovGost = new System.Windows.Forms.RadioButton();
            this.rbPostojeciGost = new System.Windows.Forms.RadioButton();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.dtpPrikaziOd = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpPrikaziDo = new System.Windows.Forms.DateTimePicker();
            this.cbSortirajTip = new System.Windows.Forms.ComboBox();
            this.nudSortiraj = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudSortiraj)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(780, 87);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(192, 20);
            this.dtpDatumRodjenja.TabIndex = 28;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(780, 113);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(192, 20);
            this.txtTelefon.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(696, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(696, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Datum rodjenja";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(780, 61);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(192, 20);
            this.txtPrezime.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(696, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Prezime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(780, 35);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(192, 20);
            this.txtIme.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(696, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ime";
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
            this.lbGosti.Size = new System.Drawing.Size(678, 202);
            this.lbGosti.TabIndex = 15;
            this.lbGosti.SelectedIndexChanged += new System.EventHandler(this.lbGosti_SelectedIndexChanged);
            // 
            // lbSobe
            // 
            this.lbSobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSobe.FormattingEnabled = true;
            this.lbSobe.HorizontalScrollbar = true;
            this.lbSobe.ItemHeight = 18;
            this.lbSobe.Location = new System.Drawing.Point(12, 247);
            this.lbSobe.Name = "lbSobe";
            this.lbSobe.ScrollAlwaysVisible = true;
            this.lbSobe.Size = new System.Drawing.Size(678, 202);
            this.lbSobe.TabIndex = 29;
            this.lbSobe.SelectedIndexChanged += new System.EventHandler(this.lbSobe_SelectedIndexChanged);
            // 
            // rbNovGost
            // 
            this.rbNovGost.AutoSize = true;
            this.rbNovGost.Checked = true;
            this.rbNovGost.Location = new System.Drawing.Point(699, 12);
            this.rbNovGost.Name = "rbNovGost";
            this.rbNovGost.Size = new System.Drawing.Size(70, 17);
            this.rbNovGost.TabIndex = 30;
            this.rbNovGost.TabStop = true;
            this.rbNovGost.Text = "Novi gost";
            this.rbNovGost.UseVisualStyleBackColor = true;
            this.rbNovGost.CheckedChanged += new System.EventHandler(this.rbNovGost_CheckedChanged);
            // 
            // rbPostojeciGost
            // 
            this.rbPostojeciGost.AutoSize = true;
            this.rbPostojeciGost.Location = new System.Drawing.Point(780, 12);
            this.rbPostojeciGost.Name = "rbPostojeciGost";
            this.rbPostojeciGost.Size = new System.Drawing.Size(91, 17);
            this.rbPostojeciGost.TabIndex = 31;
            this.rbPostojeciGost.Text = "Postojeci gost";
            this.rbPostojeciGost.UseVisualStyleBackColor = true;
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Location = new System.Drawing.Point(780, 193);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(192, 21);
            this.cbTip.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(696, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Tip rezervacije";
            // 
            // dtpDo
            // 
            this.dtpDo.Location = new System.Drawing.Point(780, 165);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(192, 20);
            this.dtpDo.TabIndex = 57;
            this.dtpDo.ValueChanged += new System.EventHandler(this.dtpDo_ValueChanged);
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(780, 139);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(192, 20);
            this.dtpOd.TabIndex = 56;
            this.dtpOd.ValueChanged += new System.EventHandler(this.dtpOd_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(696, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Ukupna cena";
            // 
            // txtCena
            // 
            this.txtCena.Enabled = false;
            this.txtCena.Location = new System.Drawing.Point(780, 370);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(192, 20);
            this.txtCena.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(696, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Datum do";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(696, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Datum od";
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotvrdi.Location = new System.Drawing.Point(699, 396);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(273, 53);
            this.btnPotvrdi.TabIndex = 60;
            this.btnPotvrdi.Text = "Potvrdi rezervaciju";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // dtpPrikaziOd
            // 
            this.dtpPrikaziOd.Location = new System.Drawing.Point(39, 220);
            this.dtpPrikaziOd.Name = "dtpPrikaziOd";
            this.dtpPrikaziOd.Size = new System.Drawing.Size(200, 20);
            this.dtpPrikaziOd.TabIndex = 61;
            this.dtpPrikaziOd.ValueChanged += new System.EventHandler(this.dtpPrikaziOd_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Od";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(246, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 64;
            this.label10.Text = "Do";
            // 
            // dtpPrikaziDo
            // 
            this.dtpPrikaziDo.Location = new System.Drawing.Point(273, 220);
            this.dtpPrikaziDo.Name = "dtpPrikaziDo";
            this.dtpPrikaziDo.Size = new System.Drawing.Size(200, 20);
            this.dtpPrikaziDo.TabIndex = 63;
            this.dtpPrikaziDo.ValueChanged += new System.EventHandler(this.dtpPrikaziDo_ValueChanged);
            // 
            // cbSortirajTip
            // 
            this.cbSortirajTip.FormattingEnabled = true;
            this.cbSortirajTip.Location = new System.Drawing.Point(484, 219);
            this.cbSortirajTip.Name = "cbSortirajTip";
            this.cbSortirajTip.Size = new System.Drawing.Size(100, 21);
            this.cbSortirajTip.TabIndex = 65;
            this.cbSortirajTip.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nudSortiraj
            // 
            this.nudSortiraj.Location = new System.Drawing.Point(590, 220);
            this.nudSortiraj.Name = "nudSortiraj";
            this.nudSortiraj.Size = new System.Drawing.Size(100, 20);
            this.nudSortiraj.TabIndex = 66;
            this.nudSortiraj.ValueChanged += new System.EventHandler(this.nudSortiraj_ValueChanged);
            // 
            // FormDodajRezervaciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.nudSortiraj);
            this.Controls.Add(this.cbSortirajTip);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpPrikaziDo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpPrikaziOd);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.cbTip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDo);
            this.Controls.Add(this.dtpOd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbPostojeciGost);
            this.Controls.Add(this.rbNovGost);
            this.Controls.Add(this.lbSobe);
            this.Controls.Add(this.dtpDatumRodjenja);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGosti);
            this.Name = "FormDodajRezervaciju";
            this.Text = "FormDodajRezervaciju";
            this.Load += new System.EventHandler(this.FormDodajRezervaciju_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSortiraj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbGosti;
        private System.Windows.Forms.ListBox lbSobe;
        private System.Windows.Forms.RadioButton rbNovGost;
        private System.Windows.Forms.RadioButton rbPostojeciGost;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.DateTimePicker dtpPrikaziOd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpPrikaziDo;
        private System.Windows.Forms.ComboBox cbSortirajTip;
        private System.Windows.Forms.NumericUpDown nudSortiraj;
    }
}