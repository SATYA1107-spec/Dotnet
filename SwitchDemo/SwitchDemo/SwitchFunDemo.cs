using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDemo
{
    public class SwitchFunDemo
    {
        static void Main(string[] args)
        {
            int n = 0;

            while (n < 10)
            {
                Console.Write("Enter week number : ");
                n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 0:
                        Console.WriteLine("Sunday");
                        break;

                    case 1: 
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("saturday");
                        break;
                    default:
                        Console.WriteLine("Entered week no is not valid");
                        break;
                }
            }

        }
    }
}
