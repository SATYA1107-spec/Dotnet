using System;
class Sum
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your Choice");
        int num = int.Parse(Console.ReadLine());
        int sum = 0;
        int sat = num;

        while (num > 0)
        {
            int rem = num % 10;
            sum = sum + rem*rem*rem;
            num = num / 10;
           
           
        }
        Console.WriteLine("sum of the given number is :"+sum);

    }
}