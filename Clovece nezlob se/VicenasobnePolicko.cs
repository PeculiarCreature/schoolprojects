using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloveceNezlobSe
{
    public class VicenasobnePolicko: Policko
    {
        List<Figurka> figurky = new();

        public override void PolozFigurku(Figurka figurka)
        {
            figurky.Add(figurka);
        }

        public override bool JeObsazeno()
        {
            return false;
        }
    }
}
