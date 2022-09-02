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
    public partial class FormRecepcioner : Form
    {
        List<Rezervacija> rezervacije = new List<Rezervacija>();
        Korisnik korisnik;
        Rezervacija rezervacija = null;
        bool pocetak = true;
        public FormRecepcioner(Korisnik poslat)
        {
            InitializeComponent();
            korisnik = poslat;
            label1.Text = korisnik.Ime + " " + korisnik.Prezime;
        }

        private void FormRecepcioner_Load(object sender, EventArgs e)
        {
            ucitajRezervacije();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FormDodajRezervaciju formDodajRezervaciju = new FormDodajRezervaciju();
            formDodajRezervaciju.FormClosed += azurirajRezervacije;
            formDodajRezervaciju.Show();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (rezervacija != null)
            {
                FormIzmeniRezervaciju formIzmeniRezervaciju = new FormIzmeniRezervaciju(rezervacija.Id);
                formIzmeniRezervaciju.FormClosed += azurirajRezervacije;
                formIzmeniRezervaciju.Show();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            rezervacije.Remove(rezervacija);
            osveziRezervacije();
            rezervacija = null;
            MessageBox.Show("Uspesno ste obrisali rezervaciju");
        }

        private void lbRezervacije_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pocetak)
            {
                pocetak = false;
            }
            else
            {
                rezervacija = lbRezervacije.SelectedItem as Rezervacija;
            }
        }






        private void azurirajRezervacije(object sender, FormClosedEventArgs e)
        {
            ucitajRezervacije();
        }

        public void ucitajRezervacije()
        {
            FileStream fileStream = File.Open("rezervacije.hotel", FileMode.Open);

            BinaryFormatter formatter = new BinaryFormatter();

            rezervacije = formatter.Deserialize(fileStream) as List<Rezervacija>;

            List<Rezervacija> vazece = new List<Rezervacija>();

            for (int i = 0; i < rezervacije.Count; i++)
            {
                if (Convert.ToDateTime(rezervacije[i].DatumDo).Date >= DateTime.Now.Date)
                {
                    vazece.Add(rezervacije[i]);
                }
            }


            lbRezervacije.DataSource = null;
            lbRezervacije.DataSource = vazece;

            fileStream.Dispose();
        }

        public void osveziRezervacije()
        {
            FileStream fileStream = File.Open("rezervacije.hotel", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(fileStream, rezervacije);

            fileStream.Dispose();
            pocetak = true;
            ucitajRezervacije();
        }
    }
}
