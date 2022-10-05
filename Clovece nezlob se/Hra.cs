using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloveceNezlobSe
{
    public class Hra
    {
        List<Hrac> hraci = new();
        HraciDeska hraciDeska;

        public void PridejHrace(Hrac hrac)
        {
            if (hraci.Count < hraciDeska.MaxPocetHracu)
            {
                for (int i = 0; i < 4; i++)
                {
                    Figurka figurka = new Figurka();
                    hrac.PridejFigurku(figurka);
                    hraciDeska.PolozFigurkuNaStart(figurka);
                }
                hraci.Add(hrac);
            }
            else
            {
                throw new Exception($"Hráč {hrac.Jmeno} nelze přidat, hrací deska je plna");
            }
        }

        public Hra(HraciDeska hraciDeska)
        {
            this.hraciDeska = hraciDeska;
        }

        public void Start()
        {
            var kostka = new Kostka(6);

            while (true)
            {
                if (hraci.Any(hrac => hrac.MaFigurkyVDomecku()))
                {
                    Console.WriteLine("Máme vítěze, hra skončila.");
                }

                foreach (var hrac in hraci)
                {
                    int hod = kostka.Hod();
                }
            }
        }

    }
}
