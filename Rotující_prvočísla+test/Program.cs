using System;



public class Pepa
{




    private static void Main(string[] args)
    {

        var v = Console.ReadLine();
        int n = int.Parse(v);
        List<int> prime = new List<int>();
        List<int> circPrime = new List<int>();


        for (int i = 2; i <= 2000000; i++)
        {
            if (circPrime.Count >= n) break;
            if (isPrime(i))
            {
                string primeStr = i.ToString();
                bool isRotatingPrime = true;
                for (int k = 0; k < primeStr.Length; k++)
                {
                    string newStr = "";
                    for (int f = 1; f < primeStr.Length; f++)
                    {
                        newStr += primeStr[f];
                    }

                    newStr += primeStr[0];
                    primeStr = newStr;
                    if (!isPrime(int.Parse(newStr))) isRotatingPrime = false;
                }
                if (isRotatingPrime)
                {
                    circPrime.Add(i);
                }
            }
        }

        Console.WriteLine(n + "=>" + circPrime[n - 1]);



    }
    public static bool isPrime(int num)
    {
        bool isPrime = true;
        for (int j = 2; j <= Math.Sqrt(num); j++)
        {
            if (num % j == 0)
            {
                isPrime = false;
                break;
            }
        }
        return isPrime;
    }
}