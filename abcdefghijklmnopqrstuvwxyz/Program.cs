using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * 
 
vkbjbzmbgb
abcccpzouv
fedopwlmcl
glmnqrszyw
hkrhiutymj
ijqcmvwxoc
pcvlpqzphl
hsgvoklcxy
urdjusmbmz
rchbcausnp
    
 **/
class Solution
{
    static void Main(string[] args)
    {
        char[] c = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        int cc = 0;
        int z = 0;
        int n = int.Parse(Console.ReadLine());
        string[] m = new string[n];
        for (int i = 0; i < n; i++)
        {
            m[i] = Console.ReadLine();
            z = m[i].Length;
        }

        for (int i = 0; i < n; i++)
        {
            for (int k = 0; k < m[i].Length; k++)
            {
                if (m[i][k] == 'a')
                {
                    StringBuilder sb = new StringBuilder(m[i]);
                    sb[k] = Char.ToUpper(c[cc]);
                    cc++;
                    m[i] = sb.ToString();
                    int il = i;
                    int kl = k;
                    bool b = true;
                    Console.WriteLine("if " + i + ":" + k);
                    while (cc < c.Length && b)
                    {
                        if (kl < z - 1) if (m[il][kl + 1] == cc)
                            {
                                Console.WriteLine("kl++ " + cc);
                                kl++;
                                StringBuilder sb2 = new StringBuilder(m[il]);
                                sb2[kl] = Char.ToUpper(c[cc]);
                                cc++;
                                m[il] = sb2.ToString();
                                kl = kl + 1;
                            }
                        else if (kl > 1) if (m[il][kl - 1] == cc)
                        {
                            Console.WriteLine("kl-- " + cc);
                            kl--;
                            StringBuilder sb2 = new StringBuilder(m[il]);
                            sb2[kl] = Char.ToUpper(c[cc]);
                            cc++;
                            m[il] = sb2.ToString();
                        }

                        else if (il < n - 1) if (m[il + 1][kl] == cc)
                        {
                            Console.WriteLine("il++ " + cc);
                            il++;
                            StringBuilder sb2 = new StringBuilder(m[il]);
                            sb2[kl] = Char.ToUpper(c[cc]);
                            cc++;
                            m[il] = sb2.ToString();
                        }
                        else if (il > 1) if (m[il - 1][kl] == cc)
                        {
                            Console.WriteLine("il-- " + cc);
                            il--;
                            StringBuilder sb2 = new StringBuilder(m[il]);
                            sb2[kl] = Char.ToUpper(c[cc]);
                            cc++;
                            m[il] = sb2.ToString();
                        }
                        else
                        {
                            cc = 0;
                            b = false;
                        }
                        Console.WriteLine("While " + cc);
                    }
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int k = 0; k < m[i].Length; k++)
            {
                if (Char.ToUpper(m[i][k]) == m[i][k])
                {
                    StringBuilder sb3 = new StringBuilder(m[i]);
                    sb3[k] = Char.ToUpper(c[cc]);
                    m[i] = sb3.ToString();
                }
                else
                {
                    StringBuilder sb3 = new StringBuilder(m[i]);
                    sb3[k] = '-';
                    m[i] = sb3.ToString();
                }
            }
        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        foreach (string g in m) Console.WriteLine(g);
    }
}