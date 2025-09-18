using System;
using System.Runtime.ExceptionServices;
class array2
{
    public static void Main(string[] args)
    {
        int[] a = new int[6];
        a[0] = 1;
        a[1] = 2;
        a[2] = 3;
        a[3] = 4;
        a[4] = 5;
        a[5] = 6;

        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]+" ");
        }

    }
}