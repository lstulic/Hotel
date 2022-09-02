using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVP_Projekat_Lazar_Stulic_RT_1_20.Klase;

namespace TVP_Projekat_Lazar_Stulic_RT_1_20
{
    public partial class formPrijava : Form
    {
        List<Korisnik> korisnici = new List<Korisnik>();
        public formPrijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < korisnici.Count; i++)
            {
                if (korisnici[i].KorisnickoIme == txtKor.Text.Trim() && korisnici[i].Lozinka == txtLozinka.Text.Trim())
                {
                    if (korisnici[i].Vrsta)
                    {
                        FormAdministracija formAdministracija = new FormAdministracija(korisnici[i]);
                        formAdministracija.FormClosed += FormaZatvorena;
                        formAdministracija.Show();
                        this.Hide();
                        MessageBox.Show("Uspesno ste se prijavili kao Administrator");
                        break;
                    }
                    else
                    {
                        FormRecepcioner formRecepcioner = new FormRecepcioner(korisnici[i]);
                        formRecepcioner.FormClosed += FormaZatvorena;
                        formRecepcioner.Show();
                        this.Hide();
                        MessageBox.Show("Uspesno ste se prijavili kao Recepcioner");
                    }
                }
            }
            
        }

        private void FormaZatvorena(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        public void ucitajKorisnike()
        {
            FileStream fileStream = File.Open("korisnici.hotel", FileMode.Open);

            BinaryFormatter formatter = new BinaryFormatter();

            korisnici = formatter.Deserialize(fileStream) as List<Korisnik>;

            fileStream.Dispose();
        }

        private void formPrijava_Load(object sender, EventArgs e)
        {
            ucitajKorisnike();
        }
    }
}
