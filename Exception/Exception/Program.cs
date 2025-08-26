using System;

class Sample
{
    public static void Main(string[] args)
    {
        string userName = Console.ReadLine();
        Console.WriteLine("Enter number c ");
        Console.WriteLine(userName);
        int c =Convert.ToInt32(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int a = 1;
        int b = 0;
        Console.WriteLine(a+b);
        try
        {
            Console.WriteLine(a / b);
        }
        catch (Exception e) 
        {
            Console.WriteLine(e.ToString());
        }
        try
        {
            Console.WriteLine(a % b);
        }
        catch(Exception e) 
        {
            Console.WriteLine(e.ToString());
        }
        Console.WriteLine(a-b);
    }
}