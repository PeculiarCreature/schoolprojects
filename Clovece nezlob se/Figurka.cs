using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloveceNezlobSe
{
    public class Figurka
    {
        Policko policko;

        public bool JeVDomecku()
        {
            return policko is Domecek;
        }

    }
}
