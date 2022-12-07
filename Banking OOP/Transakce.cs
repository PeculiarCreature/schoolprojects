using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_OOP
{
     public class Transakce
    {
        public decimal Amount { get; }
        public DateTime Datum { get; }
        public string Notes { get; }

        public Transakce(decimal mnozstvi, DateTime datum, string note)
        {
            Amount = mnozstvi;
            Datum = datum;
            Notes = note;
        }

    }
}
