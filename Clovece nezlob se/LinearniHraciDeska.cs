using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloveceNezlobSe
{
    public class LinearniHraciDeska: HraciDeska
    {
        public override int MaxPocetHracu
        {
            get
            {
                return int.MaxValue;
            }
        }

        List<Policko> policka = new();

        public LinearniHraciDeska(int pocetPolicek)
        {
            policka.Add(new StartovniPolicko());

            for (int i = 0; i < pocetPolicek - 2; i++)
            {
                var policko = new StandartniPolicko();
                policka.Add(policko);
            }

            var domecek = new Domecek();
            policka.Add(domecek);
        }

        public override void PolozFigurkuNaStart(Figurka figurka)
        {
            if (policka[0] is not StartovniPolicko)
            {
                throw new InvalidOperationException("Něco je špatně.");
            }
            policka[0].PolozFigurku(figurka);
        }
    }
}
