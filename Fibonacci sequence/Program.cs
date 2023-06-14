using System;
using System.Collections.Generic;

namespace LogicalPrograms
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Zadajete číslo:");
            var v = Console.ReadLine();
            float n = int.Parse(v);
            float firstNumber = 0, secondNumber = 1, nextNumber = 0;
            List<float> numbers = new List<float>();
            List<float> final = new List<float>();


            while (true)
            {
                numbers.Add(nextNumber);
                nextNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = nextNumber;
                if (nextNumber > n) break;
            }

            float h = n;

            while (true) 

            {
                
                float b = numbers.Where(x => x < h).LastOrDefault();
                if (b == 0)
                {
                    final.Add(1);
                }
                if (b < 1) break;
                float a = h - b;                
                final.Add(b);
                b = a;
                h = a;
                
            }

            int lastIndex = final.Count - 1;
            int secondToLastIndex = final.Count - 2;
            int thirdToLastIndex = final.Count - 3;
            if (final[lastIndex] == 1 && final[secondToLastIndex] == 1)
            {
                final.RemoveAt(lastIndex);
                final[secondToLastIndex] = 2;
            }

            if (final[lastIndex] == 1 && final[secondToLastIndex] == 1 && final[thirdToLastIndex] == 1)
            {
                final.RemoveAt(lastIndex);
                final.RemoveAt(secondToLastIndex);
                final[thirdToLastIndex] = 3;
            }
            if (final[lastIndex] == 1 && final[secondToLastIndex] == 2)
            {
                final.RemoveAt(lastIndex);
                final[secondToLastIndex] = 3;
            }


            final.ForEach(Console.WriteLine);
            
        }    
    }
}