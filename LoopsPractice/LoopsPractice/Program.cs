using System;
using System.Transactions;

class Loopsdemo
{
    static void Main(string[] args)
    {
        Console.Write("Enter any Number you want to reverse : ");
        int n = Convert.ToInt32(Console.ReadLine());
        int pal = n;
        int rev = 0;
        int rem;
        while (n > 0)
        {
            rem = n % 10;
            rev = rev * 10 + rem;
            n = n / 10;
            Console.WriteLine(rev);
        }
        Console.WriteLine(rev);
        if (pal == rev)
        {
            Console.WriteLine("Given number is palindrome");
        }


    }
}