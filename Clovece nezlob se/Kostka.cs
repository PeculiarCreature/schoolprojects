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
            return Random.Shared.Next(1, 6);
        }

    }
}
