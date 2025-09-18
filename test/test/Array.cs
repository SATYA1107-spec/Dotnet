using System;
class Arraydemo
{
    public static void Main(string[] args)
    {
        int[] a = { 1, 2, 3, 4, 5, 45 };

        string[] s = { "satya", "naresh" };

        foreach (string s2 in s)
        {
            Console.WriteLine(s2);
        }

        foreach (int i in a)
        {
            Console.WriteLine(i);
        }
    }
}