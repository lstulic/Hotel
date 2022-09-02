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
    public partial class FormRezervacije : Form
    {
        List<Rezervacija> rezervacije = new List<Rezervacija>();
        Rezervacija izabrana;
        bool pocetak = false;
        public FormRezervacije()
        {
            InitializeComponent();
        }

        private void FormRezervacije_Load(object sender, EventArgs e)
        {
            btnDodaj.Enabled = true;
            btnIzmeni.Enabled = false;
            btnObrisi.Enabled = false;
            ucitajRezervacije();
            cbTip.Items.Add("Pun pansion");
            cbTip.Items.Add("Polu pansion");
            cbTip.Items.Add("Samo dorucak");
            cbTip.SelectedIndex = 0;
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

            if (!txtGost.Text.Equals("") && !txtSoba.Text.Equals("") && !txtCena.Text.Equals(""))
            {
                if ((Int32.TryParse(txtSoba.Text, out int idSobe)) && (Int32.TryParse(txtGost.Text, out int idGosta)) && (Double.TryParse(txtCena.Text, out double ukupnaCena)))
                {
                    if (dtpOd.Value < dtpDo.Value)
                    {
                        int id = rezervacije[rezervacije.Count - 1].Id;
                        //int id, int idSobe, int idGosta, string datumOd, string datumDo, double ukupnaCena, int tip
                        upisiRezervaciju(id, idSobe, idGosta, dtpOd.Value.ToShortDateString(), dtpDo.Value.ToShortDateString(), ukupnaCena, cbTip.SelectedIndex);
                        MessageBox.Show("Uspesno ste dodali rezervaciju");
                    }
                    else
                    {
                        MessageBox.Show("Datum pocetka rezervacije mora biti manji od kraja rezervacije!");
                    }
                }
                else
                {
                    MessageBox.Show("Niste uneli validne podatke!");
                }
                
            }
            else
            {
                MessageBox.Show("Niste uneli sve potrebne podatke!");
            }
            txtSoba.Clear();
            txtGost.Clear();
            txtCena.Clear();
            cbTip.SelectedIndex = 0;

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            
            if (!txtGost.Text.Equals("") && !txtSoba.Text.Equals("") && !txtCena.Text.Equals(""))
            {
                if ((Int32.TryParse(txtSoba.Text, out int idSobe)) && (Int32.TryParse(txtGost.Text, out int idGosta)) && (Double.TryParse(txtCena.Text, out double ukupnaCena)))
                {
                    if (dtpOd.Value < dtpDo.Value)
                    {
                        int indeks = rezervacije.IndexOf(izabrana);
                        rezervacije[indeks].IdSobe = idSobe;
                        rezervacije[indeks].IdGosta = idGosta;
                        rezervacije[indeks].DatumOd = dtpOd.Value.ToShortDateString();
                        rezervacije[indeks].DatumDo = dtpDo.Value.ToShortDateString();
                        rezervacije[indeks].UkupnaCena = ukupnaCena;
                        rezervacije[indeks].Tip = cbTip.SelectedIndex;
                        osveziRezervacije();
                        MessageBox.Show("Uspesno ste izmenili rezervaciju");
                    }
                    else
                    {
                        MessageBox.Show("Datum pocetka rezervacije mora biti manji od kraja rezervacije!");
                    }
                }
                else
                {
                    MessageBox.Show("Niste uneli validne podatke!");
                }
            }
            else
            {
                MessageBox.Show("Niste uneli sve potrebne podatke");
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            rezervacije.Remove(izabrana);
            izabrana = null;
            osveziRezervacije();
            MessageBox.Show("Uspesno ste obrisali rezervaciju");
        }

        private void lbRezervacije_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbIzmeni.Checked)
            {
                if (pocetak)
                {
                    pocetak = false;
                }
                else
                {
                    izabrana = lbRezervacije.SelectedItem as Rezervacija;
                    txtSoba.Text = izabrana.IdSobe.ToString();
                    txtGost.Text = izabrana.IdGosta.ToString();
                    dtpOd.Text = izabrana.DatumOd;
                    dtpDo.Text = izabrana.DatumDo;
                    txtCena.Text = izabrana.UkupnaCena.ToString();
                    if (izabrana.Tip == 0)
                    {
                        cbTip.SelectedIndex = 0;
                    }
                    else if (izabrana.Tip == 1)
                    {
                        cbTip.SelectedIndex = 1;
                    }
                    else
                    {
                        cbTip.SelectedIndex = 2;
                    }
                }
            }

        }



        public void ucitajRezervacije()
        {
            FileStream fileStream = File.Open("rezervacije.hotel", FileMode.Open);

            BinaryFormatter formatter = new BinaryFormatter();

            rezervacije = formatter.Deserialize(fileStream) as List<Rezervacija>;

            lbRezervacije.DataSource = null;
            lbRezervacije.DataSource = rezervacije;

            fileStream.Dispose();
        }

        public void upisiRezervaciju(int id, int idSobe, int idGosta, string datumOd, string datumDo, double ukupnaCena, int tip)
        {
            FileStream fileStream = File.Open("rezervacije.hotel", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();

            //int id, int idSobe, int idGosta, string datumOd, string datumDo, double ukupnaCena, int tip


            rezervacije.Add(new Rezervacija(id + 1, idSobe, idGosta, datumOd, datumDo, ukupnaCena, tip));


            formatter.Serialize(fileStream, rezervacije);

            fileStream.Dispose();
            pocetak = true;
            ucitajRezervacije();
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
