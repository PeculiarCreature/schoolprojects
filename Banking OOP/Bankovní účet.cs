using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_OOP
{
    public class Bankovní_účet
    {
       public string Vlastnik { get; set; }

       public decimal Castka 
        {
            get
            {
                decimal castka = 0;
                foreach (var item in všechnyTransakce)
                {
                    castka += item.Mnozstvi;
                }

                return castka;
            }                               
                
        }

       public string Cislouctu { get; }

       private static int accountNumberSeed = 1234567890;

       private List<Transakce> všechnyTransakce = new List<Transakce>();

        public Bankovní_účet (string jmeno, decimal počátečníCastka) 
        {
            this.Cislouctu = accountNumberSeed.ToString();
            accountNumberSeed++;

            Vlastnik = jmeno;
            Vklad(počátečníCastka, DateTime.Now, "Počáteční částka");
        }

        public void Vklad(decimal mnozstvi, DateTime datum, string note)
        {
            if (mnozstvi <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(mnozstvi), "Váš vklad nesmí být záporné číslo");
            }
            var deposit = new Transakce(mnozstvi, datum, note);
            všechnyTransakce.Add(deposit);
        }

        public void Výběr(decimal mnozstvi, DateTime datum, string note)
        {
            if (mnozstvi <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(mnozstvi),"Výběr nesmí být záporné číslo");
            }
            if (Castka - mnozstvi < 0)
            {
                throw new InvalidOperationException("Jste moc chudý na to, abyste si vybral částku této výše, najděte si práci");
            }
            var výběr = new Transakce(-mnozstvi, datum, note);
            všechnyTransakce.Add(výběr);
        }
    
    }
}
