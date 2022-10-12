using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloveceNezlobSe
{
    public abstract class HraciDeska
    {

        public abstract int MaxPocetHracu { get; }

        public abstract void PolozFigurkuNaStart(Figurka figurka);

        public abstract bool JeFigurkaVDomecku(Figurka figurka);

        public abstract bool pokuddum(Figurka figurka, int pocetPolicek);

        //public abstract bool zabij(Figurka figurka, int pocetPolicek);

        public abstract bool PosunFigurku(Figurka figurka, int pocetPolicek);

        public abstract void Vypis();

    }
}
