using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat_Lazar_Stulic_RT_1_20.Klase
{
    [Serializable]
    public class Soba
    {
        private int id;
        private int brojSobe;
        private int brojKreveta;
        private bool tipSobe;
        private double cena;
        private double popust;
        private int minDana;

        public Soba(int id, int brojSobe, int brojKreveta, bool tipSobe, double cena, double popust, int minDana)
        {
            this.id = id;
            this.brojSobe = brojSobe;
            this.brojKreveta = brojKreveta;
            this.tipSobe = tipSobe;
            this.cena = cena;
            this.popust = popust;
            this.minDana = minDana;
        }

        public int Id { get => id; set => id = value; }
        public int BrojSobe { get => brojSobe; set => brojSobe = value; }
        public int BrojKreveta { get => brojKreveta; set => brojKreveta = value; }
        public bool TipSobe { get => tipSobe; set => tipSobe = value; }
        public double Cena { get => cena; set => cena = value; }
        public double Popust { get => popust; set => popust = value; }
        public int MinDana { get => minDana; set => minDana = value; }

        public override string ToString()
        {
            return "ID: " + this.id + ", Broj sobe: " + this.brojSobe.ToString() + ", Broj kreveta: " + this.brojKreveta.ToString() + ", Tip sobe: " + ((this.tipSobe)?"Standard":"Lux") + ", Cena: " + this.cena.ToString() + "$, Popust: " + this.popust.ToString() + "$, Minimalno dana: " + this.minDana.ToString();
        }
    }
}
