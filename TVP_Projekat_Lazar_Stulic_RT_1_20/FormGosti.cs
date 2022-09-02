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
    public partial class FormGosti : Form
    {
        List<Rezervacija> rezervacije = new List<Rezervacija>();
        List<Gost> gosti = new List<Gost>();
        Gost izabran;
        bool pocetak = false;


        public FormGosti()
        {
            InitializeComponent();
        }

        private void FormGosti_Load(object sender, EventArgs e)
        {
            btnDodaj.Enabled = true;
            btnIzmeni.Enabled = false;
            btnObrisi.Enabled = false;
            ucitajGoste();
            ucitajRezervacije();
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
            if (!txtIme.Text.Equals("") && !txtPrezime.Text.Equals("") && !txtTelefon.Text.Equals(""))
            {
                int id = gosti[gosti.Count - 1].Id;
                //int id, string ime, string prezime, string datumRodjenja, string telefon
                upisiGosta(id, txtIme.Text, txtPrezime.Text, dtpDatum.Value.ToShortDateString(), txtTelefon.Text);
                MessageBox.Show("Uspesno ste dodali gosta");
            }
            else
            {
                MessageBox.Show("Niste uneli sve potrebne podatke");
            }
            txtIme.Clear();
            txtPrezime.Clear();
            txtTelefon.Clear();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (!txtIme.Text.Equals("") && !txtPrezime.Text.Equals("") && !txtTelefon.Text.Equals(""))
            {
                int indeks = gosti.IndexOf(izabran);
                gosti[indeks].Ime = txtIme.Text;
                gosti[indeks].Prezime = txtPrezime.Text;
                gosti[indeks].DatumRodjenja = dtpDatum.Value.ToShortDateString();
                gosti[indeks].Telefon = txtTelefon.Text;
                osveziGoste();
                MessageBox.Show("Uspesno ste izmenili gosta");
            }
            else
            {
                MessageBox.Show("Niste uneli sve potrebne podatke");
            }
            txtIme.Clear();
            txtPrezime.Clear();
            txtTelefon.Clear();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int indeks = -1;
            for (int i = 0; i < rezervacije.Count; i++)
            {
                if (rezervacije[i].IdGosta == izabran.Id)
                {
                    indeks = i;
                    rezervacije.RemoveAt(indeks);
                    i--;
                }
            }

            gosti.Remove(izabran);
            osveziGoste();
            osveziRezervacije();

            txtIme.Clear();
            txtPrezime.Clear();
            txtTelefon.Clear();
            MessageBox.Show("Uspesno ste obrisali gosta");
        }

        private void lbGosti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbIzmeni.Checked)
            {
                if (pocetak)
                {
                    pocetak = false;
                }
                else
                {
                    izabran = lbGosti.SelectedItem as Gost;
                    txtIme.Text = izabran.Ime;
                    txtPrezime.Text = izabran.Prezime;
                    txtTelefon.Text = izabran.Telefon;
                    dtpDatum.Text = izabran.DatumRodjenja;
                }
            }
        }




        

        public void ucitajGoste()
        {
            FileStream fileStream = File.Open("gosti.hotel", FileMode.Open);

            BinaryFormatter formatter = new BinaryFormatter();

            gosti = formatter.Deserialize(fileStream) as List<Gost>;

            lbGosti.DataSource = null;
            lbGosti.DataSource = gosti;

            fileStream.Dispose();
        }

        public void upisiGosta(int id, string ime, string prezime, string datumRodjenja, string telefon)
        {
            FileStream fileStream = File.Open("gosti.hotel", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();

            //int id, string ime, string prezime, string datumRodjenja, string telefon


            gosti.Add(new Gost(id + 1, ime, prezime, datumRodjenja, telefon));


            formatter.Serialize(fileStream, gosti);

            fileStream.Dispose();
            pocetak = true;
            ucitajGoste();
        }

        public void osveziGoste()
        {
            FileStream fileStream = File.Open("gosti.hotel", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(fileStream, gosti);

            fileStream.Dispose();
            pocetak = true;
            ucitajGoste();
        }




        public void ucitajRezervacije()
        {
            FileStream fileStream = File.Open("rezervacije.hotel", FileMode.Open);

            BinaryFormatter formatter = new BinaryFormatter();

            rezervacije = formatter.Deserialize(fileStream) as List<Rezervacija>;


            fileStream.Dispose();
        }

        public void osveziRezervacije()
        {
            FileStream fileStream = File.Open("rezervacije.hotel", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(fileStream, rezervacije);

            fileStream.Dispose();
            ucitajRezervacije();
        }

    }
}
