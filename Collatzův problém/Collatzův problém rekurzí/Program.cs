﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lepší_Collatz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n = 1;
            long c = 0;
            long ln = 0;
            long nn = 0;


            Console.Write("Zadejte začáteční číslo:");
            n = long.Parse(Console.ReadLine());
            Console.Write("Zadejte poslední číslo:");
            long r = long.Parse(Console.ReadLine());

            DateTime start = DateTime.Now; //měření času procesu záčátek

            while (true)
            {
                n++;
                c = 0;
                Console.WriteLine(n + ":" + f(n) + ":" + c);
                if (c > ln)
                {
                    nn = n;
                    ln = c;
                }
                if (n >= r) 
                {
                    Console.WriteLine("Číslo s nejvíce iteracema: " + nn + " - " + ln + " Iterací.");
                    break;
                }
            }

            long f(long i)
            {
                //Console.Write(i + "=>");
                if (i > 1)
                {
                    if (i % 2 == 0) i /= 2;
                    else i = i * 3 + 1;
                    c++;
                    return f(i);
                }
                else return i;
            }

            DateTime end = DateTime.Now; //měření času procesu konec
            TimeSpan ts = (end - start);
            Console.WriteLine("Elapsed Time is {0} ms", ts.TotalMilliseconds);
        }        
    }

}
