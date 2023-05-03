// See https://aka.ms/new-console-template for more information
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
      /* JEN MOJE POZNÁMKY
       new int arr y = 1,2,3,4,5,6,7,8,9,10
       new int arr x = 1,2,3,4,5,6,7,8,9,10
       new int arr xx
       new int arr yx
        new int n = 10

    int p = místo intu v array


    FIND M SLOPE


    foreach int in y and in x
    arr y p1 + arr x p2 = p1 in arr yx
    p++

    foreach int in x 
    p1 * p1 = p1 in arr xx
    p++
    }

    Sum each int in arr x = int Sx
    Sum each int in arr y = int Sy
    Sum each int in arr yx = int Syx
    Sum each int in arr xx= int Sxx

    CALCULATE SLOPE M

        int M = ((n * Syx) - (Sx * Sy)) / (n * Sxx) - (Sx * Sx)

    CALCULATE INTERCEPT B

        int B = Sy - (M * Sx) / n

    EQUATION OF A LINE

        q = (M * p1 in arr x) + B

*/

        int c = 55;//Vaše číslo

        int[] x = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
        int[] y = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20};
        float[] xy = new float[Math.Min(x.Length, y.Length)];
        float[] xx = new float[Math.Min(x.Length, y.Length)];
        int n = 10;

        for (int i = 0; i < Math.Min(x.Length, y.Length); i++)
        {
            xy[i] = x[i] * y[i];
        }

        for (int i = 0; i < xx.Length; i++)
        {
            xx[i] = x[i] * x[i];
        }

        float Sx = 0;

        for (int i = 0; i < x.Length; i++)
        {
            Sx += x[i];
        }

        float Sy = 0;

        for (int i = 0; i < x.Length; i++)
        {
            Sy += y[i];
        }

        float Sxy = 0;

        for (int i = 0; i < xy.Length; i++)
        {
            Sxy += xy[i];
        }

        float Sxx = 0;

        for (int i = 0; i < x.Length; i++)
        {
            Sxx += xx[i];
        }

        float M = ((n * Sxy) - (Sx * Sy)) / ((n * Sxx) - (Sx * Sx));
        float B = (Sy - (M * Sx)) / n;

        float q = (M * c) + B;
        
        Console.WriteLine(q); //predikce
        
    }

}

    

    
