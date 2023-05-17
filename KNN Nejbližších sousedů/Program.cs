/* k-NN: k-nejbližších sousedů (k-NN)

Vytvořit dataset

 

    List<Tuple<double, double, string>> trainingData = new List<Tuple<double, double, string>>
    {
        Tuple.Create(1.0, 2.0, "ClassA"),
        Tuple.Create(3.0, 4.0, "ClassB"),
        // ...další body...
    };

 

Náš bod

 

    Tuple<double, double> testPoint = Tuple.Create(2.5, 3.5);

 

Najdi vzdálenost

 

    int d = vydálenost

 

    Foreach Tuple T in trainingData, i++

 

    d = √[(T(x) - testPoint(x))na druhou + (T(y) - testPoint(y)na druhou)]
    d = store item in Turple T
 

Najdi k nejbližších Turplů

 

    metoda řazení turplů?

*/

using System;

using System.Linq;

using System.IO;

using System.Text;

using System.Collections;

using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace Program;
class Program
{

    static void Main(string[] args)
    {
        List<Tuple<double, double, string>> trainingData = new List<Tuple<double, double, string>>
        {
            Tuple.Create(1.0, 2.0, "ClassA"),
            Tuple.Create(2.0, 4.0, "ClassA"),
            Tuple.Create(3.0, 3.0, "ClassA"),
            Tuple.Create(4.0, 1.0, "ClassA"),
            Tuple.Create(5.0, 5.0, "ClassB"),
            Tuple.Create(6.0, 7.0, "ClassB"),
            Tuple.Create(7.0, 6.0, "ClassB"),
            Tuple.Create(8.0, 8.0, "ClassB"),

        };

        Tuple<double, double> testPoint = Tuple.Create(7.5, 6.5);

        List <double> d = new List<double>();
        int i = 0;
        double p = 0;

        foreach (Tuple<double, double, string> T in trainingData)
        {

            p = ((T.Item1*T.Item1) - (testPoint.Item1*testPoint.Item1)) + ((T.Item2*T.Item2) - (testPoint.Item2*testPoint.Item2));
            d.Add(Math.Sqrt(p));
    
                i++;

        }
        int[] arr = { 5, 2, 8, 1, 9, 3 };

        // Get the three lowest numbers and their corresponding indexes
        var lowestThree = d.OrderBy(n => n).Take(3).Select(n => d.IndexOf(n)).ToList();

        string skupina1 = trainingData[lowestThree[0]].Item3;
        string skupina2 = trainingData[lowestThree[1]].Item3;
        string skupina3 = trainingData[lowestThree[2]].Item3;

        if (skupina1 == skupina2 || skupina1 == skupina3)
        {
            Console.WriteLine(skupina1);
        }
        else if (skupina2 == skupina3)
        {
            Console.WriteLine(skupina2);
        }
        else
        {
            Console.WriteLine("error");
        }





    }
}