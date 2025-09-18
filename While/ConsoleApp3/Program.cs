using System;
using System.Collections;

class tst
{
    public static void Main(string[] args)
    {
        Stack sa = new Stack();
        sa.Push(1);
        sa.Push(2);
        sa.Push(3);
        sa.Push(4);
        sa.Push(5);
        sa.Push(6);

        foreach (int ia in sa)
        Console.WriteLine(ia);
        Console.WriteLine("...............................");
      

        Console.WriteLine(sa.Equals(sa));


    }
}