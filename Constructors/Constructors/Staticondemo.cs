using System;

namespace Constructors
{
     class Staticondemo
    {
         static int i;
       

        static Staticondemo()
        {
            Console.WriteLine("this is static constructor "+i);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("this is main method");
        }

    }
}
