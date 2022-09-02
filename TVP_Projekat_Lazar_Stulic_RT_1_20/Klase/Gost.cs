using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat_Lazar_Stulic_RT_1_20.Klase
{
    [Serializable]
    public class Gost
    {
        private int id;
        private string ime;
        private string prezime;
        private string datumRodjenja;
        private string telefon;

        public Gost(int id, string ime, string prezime, string datumRodjenja, string telefon)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.datumRodjenja = datumRodjenja;
            this.telefon = telefon;
        }

        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public string Telefon { get => telefon; set => telefon = value; }

        public override string ToString()
        {
            return "ID: " + this.id + ", Ime i prezime: " + this.ime + " " + this.prezime + ", Datum rodjenja: " + this.datumRodjenja + ", Telefon: " + this.telefon;
        }
    }
}
