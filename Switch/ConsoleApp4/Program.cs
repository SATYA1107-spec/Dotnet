using System;
class Test
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter any Number");
        int n = int.Parse(Console.ReadLine());

        switch (n)
        {
            case 0:
                Console.WriteLine("Jan");
                break;
            case 1:
                Console.WriteLine("Feb");
                break;
            case 2:
                Console.WriteLine("Mar");
                break;
            case 3:
                Console.WriteLine("Apr");
                break;
            case 4:
                Console.WriteLine("May");
                break;
            case 5:
                Console.WriteLine("Jun");
                break;
            case 6:
                Console.WriteLine("July");
                break;
            case 7:
                Console.WriteLine("Aug");
                break;
            case 8:
                Console.WriteLine("Sep");
                break;
            case 9:
                Console.WriteLine("Oct");
                break;
            case 10:
                Console.WriteLine("Nov");
                break;
            case 11:
                Console.WriteLine("Dec");
                break;
            default:
                Console.WriteLine( "Not Valid");
                break;

        }
    }
}