using System;

class Palindrome
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your Number");
        int num = int.Parse(Console.ReadLine());
        int sat = num;

        int rev = 0;

        while (num > 0)
        {
            int rem = num % 10;
            num = num / 10;
            rev = rev * 10 + rem;
            
        }
        Console.WriteLine("Reverse of the given number is :"+rev);
        if (sat == rev)
        {
            Console.WriteLine("given number is Palindrome");
        }
        else
        {
            Console.WriteLine("given number is not a palindrome number");
        }

    }
}