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
                    Figurka figurka = new Figurka($"{hrac.Jmeno[0]}{i + 1}");
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
            hraciDeska.Vypis();

            while (true)
            {
                foreach (var hrac in hraci)
                {
                    Console.WriteLine($"Hraje hráč {hrac.Jmeno}");
                    int hod = kostka.Hod();
                    //bool b = false;
                    // TODO - Herní strategie - výběr figurky
                    Figurka figurka = hrac.Figurky[0];

                    for (int i = 0; hraciDeska.pokuddum(figurka, hod); i++)
                    {
                        figurka = hrac.Figurky[i];
                        if (i >= 3)
                        {
                            //b = true;
                            break;
                        }
                    }
                    /*if (b) //- snažila jsem se udělat, aby figurka pokud má na výběr mezi normálním tahem a tahem s vyhozením preferovala tah s vyhozením,
                     *           bohužel se mi nějak nepodařilo správně vytvořit "zabij", je to v linearni hraci desce....
                    {
                        for(int i=0; hraciDeska.zabij(figurka) && i>=3; i++)
                        {
                            figurka = hrac.Figurky[i];
                        }
                    }*/ //



                    hraciDeska.PosunFigurku(figurka, hod);
                    hraciDeska.Vypis();
                    if (JeDohrano())
                    {
                        Console.WriteLine($"Máme vítěze: {hrac.Jmeno}, hra skončila.");
                        return;
                    }
                }
            }

            Console.WriteLine("Konec všeho.");
        }

        private bool JeDohrano()
        {
            foreach (var hrac in hraci)
            {
                if (hrac.Figurky.All(figurka => hraciDeska.JeFigurkaVDomecku(figurka)))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
