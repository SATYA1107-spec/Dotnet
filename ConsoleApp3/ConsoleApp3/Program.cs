using System;
using System.Runtime.Serialization.Formatters;

class MOde
{
    public static void Main(string[] args)
    {
        int[] a = new int[] { 10, 20, 33, 24, 42, 52};
        int[] b = new int[] {1, 2, 3, 0, 0, 0};
        foreach (int i in b)
        {
            Console.Write(i+" ");
        }
        Array.Resize(ref b, 10);
        Console.WriteLine();
        foreach (int i in b)
        {
            Console.Write(i+" ");
        }
        a.CopyTo(b, 2);
        Console.WriteLine();
        foreach (int i in a)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        foreach (int i in b)
        {
            Console.Write(i + " ");
        }
    }
}
     
  
