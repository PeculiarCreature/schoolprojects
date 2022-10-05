using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloveceNezlobSe
{
    public class Hrac
    {
        public string Jmeno { get; init; }

        List<Figurka> figurky;

        public Hrac(string jmeno)
        {
            this.Jmeno = jmeno;
        }

        public void PridejFigurku(Figurka figurka)
        {
            figurky.Add(figurka);
        }

        public bool MaFigurkyVDomecku()
        {
            return figurky.All(figurka => figurka.JeVDomecku());
        }
    }
}
