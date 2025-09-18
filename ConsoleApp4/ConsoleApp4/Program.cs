using System;
using System.Runtime.Intrinsics.Arm;

class demo
{
    public static void Main(string[] args)
    {
        int rev = 0;
        Console.WriteLine("enter number");
        int n = int.Parse(Console.ReadLine());
        int PAL = n;

        while (n > 0)
        {
          int rem = n % 10;
            rev = rev * 10 + rem;
            n = n / 10;
           
        }
        Console.WriteLine(rev);
        if (PAL == rev)
        {
            Console.WriteLine("given number is paliindrome");
        }
      
    }
    
}