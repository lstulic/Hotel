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
    public partial class FormSobe : Form
    {
        List<Rezervacija> rezervacije = new List<Rezervacija>();
        List<Soba> sobe = new List<Soba>();
        Soba izabrana;
        bool pocetak = false;

        public FormSobe()
        {
            InitializeComponent();
        }

        private void FormSobe_Load(object sender, EventArgs e)
        {
            btnDodaj.Enabled = true;
            btnIzmeni.Enabled = false;
            btnObrisi.Enabled = false;
            ucitajSobe();
            ucitajRezervacije();
            cbTip.Items.Add("Standard");
            cbTip.Items.Add("Lux");
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
            if (!txtBrojKreveta.Text.Equals("") && !txtBrojSobe.Text.Equals("") && !txtCena.Text.Equals("") && !txtPopust.Text.Equals("") && !txtMinDana.Text.Equals(""))
            {
                
                //int id, int brojSobe, int brojKreveta, bool tipSobe, double cena, double popust, int minDana
                if ( (Int32.TryParse(txtBrojSobe.Text, out int brojSobe)) && (Int32.TryParse(txtBrojKreveta.Text, out int brojKreveta)) && (Double.TryParse(txtCena.Text, out double cena)) && (Double.TryParse(txtPopust.Text, out double popust)) && (Int32.TryParse(txtMinDana.Text, out int minDana)))
                {
                    int id = sobe[sobe.Count - 1].Id;
                    upisiSobu(id, brojSobe, brojKreveta, cbTip.SelectedIndex, cena, popust, minDana);
                    MessageBox.Show("Uspesno ste dodali sobu");
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
            txtBrojKreveta.Clear();
            txtBrojSobe.Clear();
            txtCena.Clear();
            txtPopust.Clear();
            txtMinDana.Clear();
            cbTip.SelectedIndex = 0;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (!txtBrojKreveta.Text.Equals("") && !txtBrojSobe.Text.Equals("") && !txtCena.Text.Equals("") && !txtPopust.Text.Equals("") && !txtMinDana.Text.Equals(""))
            {
                if ((Int32.TryParse(txtBrojSobe.Text, out int brojSobe)) && (Int32.TryParse(txtBrojKreveta.Text, out int brojKreveta)) && (Double.TryParse(txtCena.Text, out double cena)) && (Double.TryParse(txtPopust.Text, out double popust)) && (Int32.TryParse(txtMinDana.Text, out int minDana)))
                {
                    int indeks = sobe.IndexOf(izabrana);
                    sobe[indeks].BrojSobe = brojSobe;
                    sobe[indeks].BrojKreveta = brojKreveta;
                    sobe[indeks].Cena = cena;
                    sobe[indeks].Popust = popust;
                    sobe[indeks].MinDana = minDana;
                    sobe[indeks].TipSobe = (cbTip.SelectedIndex == 0) ? true : false;
                    osveziSobe();
                    MessageBox.Show("Uspesno ste izmenili sobu");
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
            txtBrojKreveta.Clear();
            txtBrojSobe.Clear();
            txtCena.Clear();
            txtPopust.Clear();
            txtMinDana.Clear();
            cbTip.SelectedIndex = 0;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int indeks = -1;
            for (int i = 0; i < rezervacije.Count; i++)
            {
                if (rezervacije[i].IdSobe == izabrana.Id)
                {
                    indeks = i;
                    rezervacije.RemoveAt(indeks);
                    i--;
                }
            }

            sobe.Remove(izabrana);
            osveziSobe();
            osveziRezervacije();

            txtBrojKreveta.Clear();
            txtBrojSobe.Clear();
            txtCena.Clear();
            txtPopust.Clear();
            txtMinDana.Clear();
            cbTip.SelectedIndex = 0;
            MessageBox.Show("Uspesno ste obrisali sobu");
        }

        private void lbSobe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbIzmeni.Checked)
            {
                if (pocetak)
                {
                    pocetak = false;
                }
                else
                {
                    izabrana = lbSobe.SelectedItem as Soba;
                    txtBrojSobe.Text = izabrana.BrojSobe.ToString();
                    txtBrojKreveta.Text = izabrana.BrojKreveta.ToString();
                    txtCena.Text = izabrana.Cena.ToString();
                    txtPopust.Text = izabrana.Popust.ToString();
                    txtMinDana.Text = izabrana.MinDana.ToString();
                    if (izabrana.TipSobe)
                    {
                        cbTip.SelectedIndex = 0;
                    }
                    else
                    {
                        cbTip.SelectedIndex = 1;
                    }
                }
            }
        }





        public void ucitajSobe()
        {
            FileStream fileStream = File.Open("sobe.hotel", FileMode.Open);

            BinaryFormatter formatter = new BinaryFormatter();

            sobe = formatter.Deserialize(fileStream) as List<Soba>;

            lbSobe.DataSource = null;
            lbSobe.DataSource = sobe;

            fileStream.Dispose();
        }
        
        public void upisiSobu(int id, int brojSobe, int brojKreveta, int tipSobe, double cena, double popust, int minDana)
        {
            FileStream fileStream = File.Open("sobe.hotel", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();

            //int id, int brojSobe, int brojKreveta, bool tipSobe, double cena, double popust, int minDana
            
            
            if (tipSobe == 0)
            {
                sobe.Add(new Soba(id + 1, brojSobe, brojKreveta, true, cena, popust, minDana));
            }
            else
            {
                sobe.Add(new Soba(id + 1, brojSobe, brojKreveta, false, cena, popust, minDana));
            }
            

            formatter.Serialize(fileStream, sobe);

            fileStream.Dispose();
            pocetak = true;
            ucitajSobe();
        }

        public void osveziSobe()
        {
            FileStream fileStream = File.Open("sobe.hotel", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(fileStream, sobe);

            fileStream.Dispose();
            pocetak = true;
            ucitajSobe();
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
