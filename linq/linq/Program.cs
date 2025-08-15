using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] a = { 17, 20, 38, 41, 5, 62, 73, 38, };

        Array.Sort(a);
        Console.WriteLine(a.Min());
    }
}