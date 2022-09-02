using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVP_Projekat_Lazar_Stulic_RT_1_20.Klase;

namespace TVP_Projekat_Lazar_Stulic_RT_1_20
{
    public partial class FormAdministracija : Form
    {
        Korisnik korisnik;
        public FormAdministracija(Korisnik poslat)
        {
            InitializeComponent();
            korisnik = poslat;
            label1.Text = korisnik.Ime + " " + korisnik.Prezime;
        }

        private void btnGosti_Click(object sender, EventArgs e)
        {
            FormGosti formGosti = new FormGosti();
            formGosti.Show();
        }

        private void btnSobe_Click(object sender, EventArgs e)
        {
            FormSobe formSobe = new FormSobe();
            formSobe.Show();
        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            FormRezervacije formRezervacije = new FormRezervacije();
            formRezervacije.Show();
        }

        private void btnKorisnici_Click(object sender, EventArgs e)
        {
            FormKorisnici formKorisnici = new FormKorisnici(korisnik);
            formKorisnici.Show();
        }
    }
}
