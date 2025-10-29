using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AsynchrnyousThreading
{
    public class TaskTExample
    {
        public static async Task<int> AddNUm(int a , int b)
        {
            Console.WriteLine("Addition of two numbers Srarted.........");
            await Task.Delay(1000);
            return a + b;
        }
        public static void display()
        {
            Console.WriteLine("This is display method");
        }
        public static async Task Main()
        {
            
            Console.WriteLine("main method Started..............");
            Console.WriteLine(await AddNUm(10, 30));
            Console.WriteLine("Main method ended...............");
            display();
        }
       


    }
}
