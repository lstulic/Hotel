namespace TVP_Projekat_Lazar_Stulic_RT_1_20
{
    partial class FormAdministracija
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGosti = new System.Windows.Forms.Button();
            this.btnSobe = new System.Windows.Forms.Button();
            this.btnRezervacije = new System.Windows.Forms.Button();
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime prezime";
            // 
            // btnGosti
            // 
            this.btnGosti.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGosti.Location = new System.Drawing.Point(18, 65);
            this.btnGosti.Name = "btnGosti";
            this.btnGosti.Size = new System.Drawing.Size(320, 64);
            this.btnGosti.TabIndex = 1;
            this.btnGosti.Text = "Gosti";
            this.btnGosti.UseVisualStyleBackColor = true;
            this.btnGosti.Click += new System.EventHandler(this.btnGosti_Click);
            // 
            // btnSobe
            // 
            this.btnSobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobe.Location = new System.Drawing.Point(18, 135);
            this.btnSobe.Name = "btnSobe";
            this.btnSobe.Size = new System.Drawing.Size(320, 64);
            this.btnSobe.TabIndex = 2;
            this.btnSobe.Text = "Sobe";
            this.btnSobe.UseVisualStyleBackColor = true;
            this.btnSobe.Click += new System.EventHandler(this.btnSobe_Click);
            // 
            // btnRezervacije
            // 
            this.btnRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervacije.Location = new System.Drawing.Point(18, 205);
            this.btnRezervacije.Name = "btnRezervacije";
            this.btnRezervacije.Size = new System.Drawing.Size(320, 64);
            this.btnRezervacije.TabIndex = 3;
            this.btnRezervacije.Text = "Rezervacije";
            this.btnRezervacije.UseVisualStyleBackColor = true;
            this.btnRezervacije.Click += new System.EventHandler(this.btnRezervacije_Click);
            // 
            // btnKorisnici
            // 
            this.btnKorisnici.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKorisnici.Location = new System.Drawing.Point(18, 275);
            this.btnKorisnici.Name = "btnKorisnici";
            this.btnKorisnici.Size = new System.Drawing.Size(320, 64);
            this.btnKorisnici.TabIndex = 4;
            this.btnKorisnici.Text = "Korisnici";
            this.btnKorisnici.UseVisualStyleBackColor = true;
            this.btnKorisnici.Click += new System.EventHandler(this.btnKorisnici_Click);
            // 
            // FormAdministracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 356);
            this.Controls.Add(this.btnKorisnici);
            this.Controls.Add(this.btnRezervacije);
            this.Controls.Add(this.btnSobe);
            this.Controls.Add(this.btnGosti);
            this.Controls.Add(this.label1);
            this.Name = "FormAdministracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdministracija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGosti;
        private System.Windows.Forms.Button btnSobe;
        private System.Windows.Forms.Button btnRezervacije;
        private System.Windows.Forms.Button btnKorisnici;
    }
}