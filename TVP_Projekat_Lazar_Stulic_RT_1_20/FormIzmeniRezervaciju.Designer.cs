namespace TVP_Projekat_Lazar_Stulic_RT_1_20
{
    partial class FormIzmeniRezervaciju
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
            this.lbSobe = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSoba = new System.Windows.Forms.Label();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.nudSortiraj = new System.Windows.Forms.NumericUpDown();
            this.cbSortirajTip = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpPrikaziDo = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpPrikaziOd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudSortiraj)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSobe
            // 
            this.lbSobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSobe.FormattingEnabled = true;
            this.lbSobe.HorizontalScrollbar = true;
            this.lbSobe.ItemHeight = 18;
            this.lbSobe.Location = new System.Drawing.Point(12, 63);
            this.lbSobe.Name = "lbSobe";
            this.lbSobe.ScrollAlwaysVisible = true;
            this.lbSobe.Size = new System.Drawing.Size(678, 202);
            this.lbSobe.TabIndex = 30;
            this.lbSobe.SelectedIndexChanged += new System.EventHandler(this.lbSobe_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Trenutna soba: ";
            // 
            // lblSoba
            // 
            this.lblSoba.AutoSize = true;
            this.lblSoba.Location = new System.Drawing.Point(101, 13);
            this.lblSoba.Name = "lblSoba";
            this.lblSoba.Size = new System.Drawing.Size(0, 13);
            this.lblSoba.TabIndex = 32;
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Location = new System.Drawing.Point(780, 117);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(192, 21);
            this.cbTip.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(696, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Tip rezervacije";
            // 
            // dtpDo
            // 
            this.dtpDo.Location = new System.Drawing.Point(780, 89);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(192, 20);
            this.dtpDo.TabIndex = 63;
            this.dtpDo.ValueChanged += new System.EventHandler(this.dtpDo_ValueChanged);
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(780, 63);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(192, 20);
            this.dtpOd.TabIndex = 62;
            this.dtpOd.ValueChanged += new System.EventHandler(this.dtpOd_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(696, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Datum do";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(696, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Datum od";
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotvrdi.Location = new System.Drawing.Point(699, 209);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(273, 53);
            this.btnPotvrdi.TabIndex = 68;
            this.btnPotvrdi.Text = "Izmeni rezervaciju";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(696, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Ukupna cena";
            // 
            // txtCena
            // 
            this.txtCena.Enabled = false;
            this.txtCena.Location = new System.Drawing.Point(780, 183);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(192, 20);
            this.txtCena.TabIndex = 66;
            // 
            // nudSortiraj
            // 
            this.nudSortiraj.Location = new System.Drawing.Point(591, 37);
            this.nudSortiraj.Name = "nudSortiraj";
            this.nudSortiraj.Size = new System.Drawing.Size(100, 20);
            this.nudSortiraj.TabIndex = 74;
            this.nudSortiraj.ValueChanged += new System.EventHandler(this.nudSortiraj_ValueChanged);
            // 
            // cbSortirajTip
            // 
            this.cbSortirajTip.FormattingEnabled = true;
            this.cbSortirajTip.Location = new System.Drawing.Point(485, 36);
            this.cbSortirajTip.Name = "cbSortirajTip";
            this.cbSortirajTip.Size = new System.Drawing.Size(100, 21);
            this.cbSortirajTip.TabIndex = 73;
            this.cbSortirajTip.SelectedIndexChanged += new System.EventHandler(this.cbSortirajTip_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(247, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 72;
            this.label10.Text = "Do";
            // 
            // dtpPrikaziDo
            // 
            this.dtpPrikaziDo.Location = new System.Drawing.Point(274, 37);
            this.dtpPrikaziDo.Name = "dtpPrikaziDo";
            this.dtpPrikaziDo.Size = new System.Drawing.Size(200, 20);
            this.dtpPrikaziDo.TabIndex = 71;
            this.dtpPrikaziDo.ValueChanged += new System.EventHandler(this.dtpPrikaziDo_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "Od";
            // 
            // dtpPrikaziOd
            // 
            this.dtpPrikaziOd.Location = new System.Drawing.Point(40, 37);
            this.dtpPrikaziOd.Name = "dtpPrikaziOd";
            this.dtpPrikaziOd.Size = new System.Drawing.Size(200, 20);
            this.dtpPrikaziOd.TabIndex = 69;
            this.dtpPrikaziOd.ValueChanged += new System.EventHandler(this.dtpPrikaziOd_ValueChanged);
            // 
            // FormIzmeniRezervaciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 271);
            this.Controls.Add(this.nudSortiraj);
            this.Controls.Add(this.cbSortirajTip);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpPrikaziDo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpPrikaziOd);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.cbTip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDo);
            this.Controls.Add(this.dtpOd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSoba);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSobe);
            this.Name = "FormIzmeniRezervaciju";
            this.Text = "FormIzmeniRezervaciju";
            this.Load += new System.EventHandler(this.FormIzmeniRezervaciju_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSortiraj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSobe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoba;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.NumericUpDown nudSortiraj;
        private System.Windows.Forms.ComboBox cbSortirajTip;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpPrikaziDo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpPrikaziOd;
    }
}