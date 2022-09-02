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
    public partial class FormDodajRezervaciju : Form
    {
        List<Rezervacija> rezervacije = new List<Rezervacija>();
        List<Soba> filtrirane = new List<Soba>();
        List<Gost> gosti = new List<Gost>();
        List<Soba> sobe = new List<Soba>();
        Gost gost;
        Soba soba;
        double cena;
        int razlika;
        bool pocetak1 = true, pocetak2 = true;
        int pocetak3 = 0;
        public FormDodajRezervaciju()
        {
            InitializeComponent();
        }

        private void FormDodajRezervaciju_Load(object sender, EventArgs e)
        {
            dtpPrikaziOd.Value = DateTime.Now.Date;
            dtpPrikaziDo.Text = "31.12.2023";
            ucitajGoste();
            ucitajSobe();
            ucitajRezervacije();
            cbSortirajTip.Items.Add("Standard");
            cbSortirajTip.Items.Add("Lux");
            cbSortirajTip.SelectedIndex = 0;
            cbTip.Items.Add("Pun pansion");
            cbTip.Items.Add("Polu pansion");
            cbTip.Items.Add("Samo dorucak");
            cbTip.SelectedIndex = 0;
            pocetak1 = true;
            pocetak2 = true;
            dtpDo.Value = DateTime.Now.AddDays(1);
        }

        private void rbNovGost_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNovGost.Checked)
            {
                txtIme.Enabled = true;
                txtPrezime.Enabled = true;
                txtTelefon.Enabled = true;
                dtpDatumRodjenja.Enabled = true;
                txtIme.Clear();
                txtPrezime.Clear();
                txtTelefon.Clear();
                dtpDatumRodjenja.ResetText();
                gost = null;
            }
            else
            {
                txtIme.Enabled = false;
                txtPrezime.Enabled = false;
                txtTelefon.Enabled = false;
                dtpDatumRodjenja.Enabled = false;
            }
        }

        private void lbGosti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbPostojeciGost.Checked)
            {
                gost = lbGosti.SelectedItem as Gost;
                txtIme.Text = gost.Ime;
                txtPrezime.Text = gost.Prezime;
                dtpDatumRodjenja.Text = gost.DatumRodjenja;
                txtTelefon.Text = gost.Telefon;
            }
            else
            {
                gost = null;
            }
        }

        private void lbSobe_SelectedIndexChanged(object sender, EventArgs e)
        {
            soba = lbSobe.SelectedItem as Soba;
            if (soba is null)
            {
                txtCena.Text = "0";
            }
            else
            {
                razlika = (dtpDo.Value.Date - dtpOd.Value.Date).Days;
                cena = soba.Cena * razlika;
                txtCena.Text = cena.ToString();
            }
        }

        private void dtpPrikaziOd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpPrikaziOd.Value.Date > dtpPrikaziDo.Value.Date)
            {
                MessageBox.Show("Kranji datum ne moze biti manji od pocetnog!");
                dtpPrikaziDo.Text = "31.12.2023";
            }
            else
            {
                ucitajSobe();
                
                if (dtpPrikaziOd.Value.Date > dtpOd.Value.Date)
                {
                    dtpDo.Value = dtpPrikaziOd.Value.Date.AddDays(1);
                    dtpOd.Value = dtpPrikaziOd.Value.Date;
                }
                else
                {
                    dtpOd.Value = dtpPrikaziOd.Value.Date;
                    dtpDo.Value = dtpPrikaziOd.Value.Date.AddDays(1);
                }
                
                
            }


        }

        private void dtpPrikaziDo_ValueChanged(object sender, EventArgs e)
        {
            if (dtpPrikaziOd.Value.Date > dtpPrikaziDo.Value.Date)
            {
                MessageBox.Show("Kranji datum ne moze biti manji od pocetnog!");
                dtpPrikaziDo.Text = "31.12.2023";
            }
            else
            {
                ucitajSobe();
            }
        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpOd.Value.Date > dtpDo.Value.Date)
            {
                MessageBox.Show("Kranji datum ne moze biti manji od pocetnog!");
                dtpOd.ResetText();
            }
            else
            {
                if (soba is null)
                {
                    txtCena.Text = "0";
                }
                else
                {
                    razlika = (dtpDo.Value.Date - dtpOd.Value.Date).Days;
                    cena = soba.Cena * razlika;
                    txtCena.Text = cena.ToString();
                }
            }


        }

        private void dtpDo_ValueChanged(object sender, EventArgs e)
        {
            if (dtpOd.Value.Date > dtpDo.Value.Date)
            {
                MessageBox.Show("Kranji datum ne moze biti manji od pocetnog!");
                dtpDo.ResetText();
                dtpDo.Value = dtpDo.Value.AddDays(1);
            }
            else
            {
                if (soba is null)
                {
                    txtCena.Text = "0";
                }
                else
                {
                    razlika = (dtpDo.Value.Date - dtpOd.Value.Date).Days;
                    cena = soba.Cena * razlika;
                    txtCena.Text = cena.ToString();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucitajSobe();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            
            if (txtIme.Text != "" && txtPrezime.Text != "" && txtTelefon.Text != "")
            {
                if (razlika >= soba.MinDana)
                {
                    
                    int id = rezervacije[rezervacije.Count - 1].Id;
                    if (dtpOd.Value.Date >= dtpPrikaziOd.Value.Date)
                    {
                        if (rbNovGost.Checked)
                        {
                            int idGosta = gosti[gosti.Count - 1].Id;
                            //int id, string ime, string prezime, string datumRodjenja, string telefon
                            upisiGosta(idGosta, txtIme.Text, txtPrezime.Text, dtpDatumRodjenja.Value.ToShortDateString(), txtTelefon.Text);
                            //int id, int idSobe, int idGosta, string datumOd, string datumDo, double ukupnaCena, int tip
                            upisiRezervaciju(id, soba.Id, gost.Id, dtpOd.Value.ToShortDateString(), dtpDo.Value.ToShortDateString(), cena, cbTip.SelectedIndex);
                        }
                        else
                        {
                            upisiRezervaciju(id, soba.Id, gost.Id, dtpOd.Value.ToShortDateString(), dtpDo.Value.ToShortDateString(), cena, cbTip.SelectedIndex);
                        }
                        MessageBox.Show("Uspesno ste izvrsili rezervaciju.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sobu mozete rezervisati samo za dane na koje je slobodna!");
                    }
                    
                    
                }
                else
                {
                    MessageBox.Show("Soba mora biti rezervisana minimum: " + soba.MinDana + " dana!");
                }
            }
        }

        private void nudSortiraj_ValueChanged(object sender, EventArgs e)
        {
            ucitajSobe();
        }

        









        public void ucitajRezervacije()
        {
            FileStream fileStream = File.Open("rezervacije.hotel", FileMode.Open);

            BinaryFormatter formatter = new BinaryFormatter();

            rezervacije = formatter.Deserialize(fileStream) as List<Rezervacija>;


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
            ucitajRezervacije();
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
            gost = new Gost(id + 1, ime, prezime, datumRodjenja, telefon);
            Console.WriteLine(gost);
            gosti.Add(gost);


            formatter.Serialize(fileStream, gosti);

            fileStream.Dispose();
        }

        public void ucitajSobe()
        {
            FileStream fileStream = File.Open("sobe.hotel", FileMode.Open);

            BinaryFormatter formatter = new BinaryFormatter();

            sobe = formatter.Deserialize(fileStream) as List<Soba>;

            filtrirane = new List<Soba>();
            List<Soba> rezervisane = new List<Soba>();



            for (int i = 0; i < rezervacije.Count; i++)
            {
                int id = rezervacije[i].IdSobe;
                for (int j = 0; j < sobe.Count; j++)
                {
                    if (sobe[j].Id == id)
                    {
                        if ((Convert.ToDateTime(rezervacije[i].DatumOd) >= dtpPrikaziOd.Value && Convert.ToDateTime(rezervacije[i].DatumDo) <= dtpPrikaziDo.Value) || (Convert.ToDateTime(rezervacije[i].DatumDo) >= dtpPrikaziOd.Value && Convert.ToDateTime(rezervacije[i].DatumDo) <= dtpPrikaziDo.Value))
                        {
                            rezervisane.Add(sobe[j]);
                        }
                    }
                }
            }

            for (int i = 0; i < sobe.Count; i++)
            {
                if (!filtrirane.Contains(sobe[i]) && !rezervisane.Contains(sobe[i]))
                {
                    filtrirane.Add(sobe[i]);
                }
            }
            List<Soba> f = new List<Soba>();

            if (cbSortirajTip.SelectedIndex == 0)
            {
                for (int i = 0; i < filtrirane.Count - 1; i++)
                {
                    for (int j = i + 1; j < filtrirane.Count; j++)
                    {
                        string prvi = (filtrirane[i].TipSobe) ? "Standard" : "Lux";
                        string drugi = (filtrirane[j].TipSobe) ? "Standard" : "Lux";
                        if (prvi.CompareTo(drugi) < 0)
                        {
                            f.Add(filtrirane[i]);
                            filtrirane.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < filtrirane.Count - 1; i++)
                {
                    for (int j = i + 1; j < filtrirane.Count; j++)
                    {
                        string prvi = (filtrirane[i].TipSobe) ? "Standard" : "Lux";
                        string drugi = (filtrirane[j].TipSobe) ? "Standard" : "Lux";
                        if (prvi.CompareTo(drugi) > 0)
                        {
                            f.Add(filtrirane[i]);
                            filtrirane.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }

            filtrirane.AddRange(f);

            if (nudSortiraj.Value != 0)
            {
                for (int i = 0; i < filtrirane.Count; i++)
                {
                    if (filtrirane[i].BrojKreveta != nudSortiraj.Value)
                    {
                        filtrirane.RemoveAt(i);
                        i--;
                    }
                }
            }



            lbSobe.DataSource = null;
            lbSobe.DataSource = filtrirane;

            fileStream.Dispose();
        }

    }
}
