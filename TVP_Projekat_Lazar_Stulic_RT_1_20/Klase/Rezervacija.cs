using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat_Lazar_Stulic_RT_1_20.Klase
{
    [Serializable]
    public class Rezervacija
    {
        private int id;
        private int idSobe;
        private int idGosta;
        private string datumOd;
        private string datumDo;
        private double ukupnaCena;
        private int tip;

        public Rezervacija(int id, int idSobe, int idGosta, string datumOd, string datumDo, double ukupnaCena, int tip)
        {
            this.id = id;
            this.idSobe = idSobe;
            this.idGosta = idGosta;
            this.datumOd = datumOd;
            this.datumDo = datumDo;
            this.ukupnaCena = ukupnaCena;
            this.tip = tip;
        }

        public int Id { get => id; set => id = value; }
        public int IdSobe { get => idSobe; set => idSobe = value; }
        public int IdGosta { get => idGosta; set => idGosta = value; }
        public string DatumOd { get => datumOd; set => datumOd = value; }
        public string DatumDo { get => datumDo; set => datumDo = value; }
        public double UkupnaCena { get => ukupnaCena; set => ukupnaCena = value; }
        public int Tip { get => tip; set => tip = value; }

        public override string ToString()
        {
            return "ID: " + this.id + ", ID sobe: " + this.idSobe + ", ID gosta: " + this.idGosta + ", Datum od: " + this.datumOd + ", Datum do: " + this.datumDo + ", Ukupna cena: " + this.ukupnaCena + "$, Tip: " + ((this.tip == 0) ? "Pun pansion" : ((this.tip == 1) ? "Polu pansion" : "Samo dorucak"));
        }
    }
}
