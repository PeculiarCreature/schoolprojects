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
    
    }
}
