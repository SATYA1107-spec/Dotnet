using System;

class Operators
{
    public static void Main(string[] args)
    {
        int a = 10;
        int b = 20;
        int c = 30;
        if (a < b || b > c)
        {
            Console.WriteLine("correct");
        }
        else
        {
            Console.WriteLine("wrong");
        }
    }
}