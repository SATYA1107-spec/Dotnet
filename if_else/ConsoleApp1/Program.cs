using System;
class Satya
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter any number");
        int n=int.Parse(Console.ReadLine());
        if (n > 0)
        {
            Console.WriteLine("given number is positive");
          
        }
        else
        {
           Console.WriteLine("given number is negitive");      
        }
    }
}