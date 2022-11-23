using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_OOP
{
     public class Transakce
    {
        public decimal Mnozstvi { get; }
        public DateTime Datum { get; }
        public string Notes { get; }

        public Transakce(decimal mnozstvi, DateTime datum, string note)
        {
            Mnozstvi = mnozstvi;
            Datum = datum;
            Notes = note;
        }

    }
}
