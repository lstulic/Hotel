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
    public partial class FormKorisnici : Form
    {
        List<Korisnik> korisnici = new List<Korisnik>();
        int ID = 0;
        Korisnik korisnik;
        Korisnik izabran;
        bool pocetak = false;
        
        public FormKorisnici(Korisnik poslat)
        {
            InitializeComponent();
            korisnik = poslat;
        }

        private void FormKorisnici_Load(object sender, EventArgs e)
        {
            btnDodaj.Enabled = true;
            btnIzmeni.Enabled = false;
            btnObrisi.Enabled = false;
            ucitajKorisnike();
            cbVrsta.Items.Add("Admin");
            cbVrsta.Items.Add("Recepcioner");
            cbVrsta.SelectedIndex = 0;
        }

        private void rbDodaj_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDodaj.Checked)
            {
                btnDodaj.Enabled = true;
                btnIzmeni.Enabled = false;
                btnObrisi.Enabled = false;
            }
            else
            {
                btnDodaj.Enabled = false;
                btnIzmeni.Enabled = true;
                btnObrisi.Enabled = true;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!txtIme.Text.Equals("") && !txtPrezime.Text.Equals("") && !txtKorisnicko.Text.Equals("") && !txtLozinka.Text.Equals(""))
            {
                int id = korisnici[korisnici.Count - 1].Id;
                upisiKorisnika(id, txtIme.Text, txtPrezime.Text, txtKorisnicko.Text, txtLozinka.Text, cbVrsta.SelectedIndex);
                MessageBox.Show("Uspesno ste dodali korisnika");
            }
            else
            {
                MessageBox.Show("Niste uneli sve potrebne podatke");
            }
            txtIme.Clear();
            txtPrezime.Clear();
            txtKorisnicko.Clear();
            txtLozinka.Clear();
            cbVrsta.SelectedIndex = 0;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (!txtIme.Text.Equals("") && !txtPrezime.Text.Equals("") && !txtKorisnicko.Text.Equals("") && !txtLozinka.Text.Equals(""))
            {
                int indeks = korisnici.IndexOf(izabran);
                korisnici[indeks].Ime = txtIme.Text;
                korisnici[indeks].Prezime = txtPrezime.Text;
                korisnici[indeks].KorisnickoIme = txtKorisnicko.Text;
                korisnici[indeks].Lozinka = txtLozinka.Text;
                korisnici[indeks].Vrsta = (cbVrsta.SelectedIndex == 0)?true:false;
                osveziKorisnike();
                MessageBox.Show("Uspesno ste izmenili korisnika");
            }
            else
            {
                MessageBox.Show("Niste uneli sve potrebne podatke");
            }
            txtIme.Clear();
            txtPrezime.Clear();
            txtKorisnicko.Clear();
            txtLozinka.Clear();
            cbVrsta.SelectedIndex = 0;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (ID == korisnik.Id)
            {
                MessageBox.Show("Ne mozete obrisati aktivnog korisnika!");
            }
            else
            {
                korisnici.Remove(izabran);
                izabran = null;
                osveziKorisnike();
                MessageBox.Show("Uspesno ste obrisali korisnika");
            }
            txtIme.Clear();
            txtPrezime.Clear();
            txtKorisnicko.Clear();
            txtLozinka.Clear();
            cbVrsta.SelectedIndex = 0;
        }

        private void lbKorisnici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbIzmeni.Checked)
            {
                if (pocetak)
                {
                    pocetak = false;
                }
                else
                {
                    izabran = lbKorisnici.SelectedItem as Korisnik;
                    ID = izabran.Id;
                    txtIme.Text = izabran.Ime;
                    txtPrezime.Text = izabran.Prezime;
                    txtKorisnicko.Text = izabran.KorisnickoIme;
                    txtLozinka.Text = izabran.Lozinka;
                    if (izabran.Vrsta)
                    {
                        cbVrsta.SelectedIndex = 0;
                    }
                    else
                    {
                        cbVrsta.SelectedIndex = 1;
                    }
                }
            }
            
        }

        public void ucitajKorisnike()
        {
            FileStream fileStream = File.Open("korisnici.hotel", FileMode.Open);

            BinaryFormatter formatter = new BinaryFormatter();

            korisnici = formatter.Deserialize(fileStream) as List<Korisnik>;

            
            lbKorisnici.DataSource = null;
            lbKorisnici.DataSource = korisnici;
            fileStream.Dispose();
        }

        public void upisiKorisnika(int id, string ime, string prezime, string korisnickoIme, string lozinka, int vrsta)
        {
            FileStream fileStream = File.Open("korisnici.hotel", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();

            //int id, string ime, string prezime, string korisnickoIme, string lozinka, bool vrsta
            if (vrsta == 0)
            {
                korisnici.Add(new Korisnik(id + 1, ime, prezime, korisnickoIme, lozinka, true));
            }
            else
            {
                korisnici.Add(new Korisnik(id + 1, ime, prezime, korisnickoIme, lozinka, false));
            }

            formatter.Serialize(fileStream, korisnici);

            fileStream.Dispose();
            pocetak = true;
            ucitajKorisnike();
        }

        public void osveziKorisnike()
        {
            FileStream fileStream = File.Open("korisnici.hotel", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(fileStream, korisnici);

            fileStream.Dispose();
            pocetak = true;
            ucitajKorisnike();
        }






    }
}
