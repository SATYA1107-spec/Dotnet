using System;

class Demo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter number ");
        int number = int.Parse(Console.ReadLine());

        if (number%2 == 0)
        {
            Console.WriteLine("given number  is  prime number ");
        }
        else
        {
            Console.WriteLine("given number is not a prime number");
        }
    }
}