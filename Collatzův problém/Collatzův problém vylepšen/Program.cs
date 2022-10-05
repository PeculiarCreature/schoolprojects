using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collatz_ještě_lepší
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Console.Write("Zadejte začáteční číslo: ");
            string b = Console.ReadLine();

            Console.Write("Zadejte koncové číslo: ");
            string c = Console.ReadLine();

            long cc = long.Parse(c);
            long f = long.Parse(b);
            long s = 0;
            long a = f;
            long i = 0;
            long u = 0;

            DateTime start = DateTime.Now; //měření času procesu záčátek
            while (f <= cc)
          
            {               
                a = f;
                s = 0;
                while (a > 1)
                {
                    if (a % 2 == 0)
                    {
                        a /= 2;                        
                    }

                    else
                    {
                        a = a * 3 + 1;
                    }
                    s++;
                }
                
                if (s > i)
                {
                    i = s;
                    u = f;
                }
                
                Console.WriteLine(f + " ... " + a + ", počet iterací: " + s);
                f++;

            }
            Console.WriteLine("číslo s největším počtem iterací: " + u + ", jejich počet: " + i);
            DateTime end = DateTime.Now; //měření času procesu konec
            TimeSpan ts = (end - start);
            Console.WriteLine("Elapsed Time is {0} ms", ts.TotalMilliseconds);


        }
    }
}
