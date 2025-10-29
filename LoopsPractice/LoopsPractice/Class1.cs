using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPractice
{
    public class Class1 
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            int n =int.Parse(Console.ReadLine());
            int sum = 0;
            while (n > 0)
            {
                int rem = n % 10;
                sum = sum + rem*rem;
                n = n/10;
               
            }
            Console.WriteLine(sum);
           
        }
    }
}
