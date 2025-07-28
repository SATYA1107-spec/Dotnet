using System;
class Reverse
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter any Number");
        int number = int.Parse(Console.ReadLine());
        int rev = 0;
        while (number > 0)
        {
            int Rem = number % 10;
            rev = rev*10 + Rem;
            number = number / 10;
        }
        Console.WriteLine("reverse of the given number is :"+rev);
    }
}