using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloveceNezlobSe
{
    public class Kostka
    {
        int PocetSten;

        public Kostka (int pocetSten)
        {
            this.PocetSten = pocetSten;
        }
        public int Hod()
        {
            var hod = Random.Shared.Next(1, PocetSten);
            Console.WriteLine($"Kostka hodila {hod}.");

            return hod;
        }

    }
}
