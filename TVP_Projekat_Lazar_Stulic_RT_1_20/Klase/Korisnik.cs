using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat_Lazar_Stulic_RT_1_20.Klase
{
    [Serializable]
    public class Korisnik
    {
        private int id;
        private string ime;
        private string prezime;
        private string korisnickoIme;
        private string lozinka;
        private bool vrsta;

        public Korisnik(int id, string ime, string prezime, string korisnickoIme, string lozinka, bool vrsta)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
            this.vrsta = vrsta;
        }

        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public bool Vrsta { get => vrsta; set => vrsta = value; }

        public override string ToString()
        {
            return "ID: " + this.id + ", Ime i prezime: " + this.ime + " " + this.prezime + ", Korisnicko ime: " + this.korisnickoIme + ", Lozinka: " + this.lozinka + ", Vrsta: " + ((vrsta) ? "Admin" : "Recepcioner");
        }
    }
}
