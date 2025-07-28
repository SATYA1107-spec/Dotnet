using System;
using System.Runtime.Remoting.Services;
class Satya
{
    public static void Main(string[] args)
    {
        Console.WriteLine("ENTER a value");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("ENTER b value");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("enter your choice");
        string c = Console.ReadLine();

        switch (c)
        {
            case "add":
                Console.WriteLine(a+b);
                break;
            case "sub":
                Console.WriteLine("a-b");
                break;
            case "mul":
                Console.WriteLine("a*b");
                break;
            case "div":
                Console.WriteLine("a/b");
                break;
            default:
                Console.WriteLine("invalid");
                break;
        }
    }
}