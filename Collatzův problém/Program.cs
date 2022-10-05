using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prosimchciumritjauznatonemam
{
    public class Program
    {
        static void Main(string[] args)
        {
            Boolean b = false;
            List<char> ca = new List<char>();
            List<int> ia = new List<int>();

            while (true)
            {
                string s = Console.ReadLine();
                foreach (char c in s)
                {
                    for (int i = 0; i < ca.Count; i++)
                    {
                        if (ca[i] == c)
                        {
                            ia[i]++;
                            b = true;
                        }
                    }
                    if (!b)
                    {
                        ca.Add(c);
                        ia.Add(0);
                        b = false;
                    }
                    Console.WriteLine(c);
                }
                foreach (char c in ca)
                {
                    Console.WriteLine(c);
                }
                ca.Clear();
                ia.Clear();
            }
        }
    }
}
