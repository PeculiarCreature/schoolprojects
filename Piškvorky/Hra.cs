using Piškvorky;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Hra
    {
        public static void GetIndex()
        {
            Console.Write("Zadejte..řádek");
            string s = Console.ReadLine();
            Console.WriteLine("Zadejte sloupec");
            string b = Console.ReadLine();
            
            HerniPlan.VykresliTabulku()
        }
    }
}
