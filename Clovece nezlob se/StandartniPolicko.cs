using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloveceNezlobSe
{
    public class StandartniPolicko: Policko
    {
        Figurka figurka;

        public override void PolozFigurku(Figurka figurka)
        {
            if (JeObsazeno())
            {
                throw new InvalidOperationException("Policko je obsazeno");
            }

            this.figurka = figurka;
        }

        public override bool JeObsazeno()
        {
            return (this.figurka != null); // nebo můžu použít (this.Figurka is not null) či (this.Figurka is Figurka)
        }

    }
}
