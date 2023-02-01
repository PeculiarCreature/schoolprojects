using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piškvorky
{
    public class HerniPlan
    {
        public static void VykresliTabulku()
        {
            char[,] pole = new char[10, 10]; for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(0); j++)
                {
                    Console.Write(pole[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
