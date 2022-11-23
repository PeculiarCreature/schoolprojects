using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_OOP
{
     class Program
    {
        static void Main(string[] args)
        {
            var account = new Bankovní_účet("Týpek", 550);
            Console.WriteLine($"Účet {account.Cislouctu} byl vytvořen pro {account.Vlastnik} s počáteční částkou {account.Castka}");

            //Tady to bych chtěla nějak udělat do příkazového řádku + udělat, aby to vypsalo i částku a poznámky atd.
            account.Výběr(500, DateTime.Now, "Dlužil jsem za pivo");
            Console.WriteLine(DateTime.Now + "Aktuální částka ne Vašem účtě: " + account.Castka);
            account.Vklad(100, DateTime.Now, "Vyhrál jsem sázku");
            Console.WriteLine(DateTime.Now + "Aktuální částka ne Vašem účtě: " + account.Castka);
        }
    }
}
