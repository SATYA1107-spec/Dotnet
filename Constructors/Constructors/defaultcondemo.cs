using System;

namespace Constructors
{
    class defaultcondemo
    {
        int i;
        public defaultcondemo()
        {
            Console.WriteLine("constructor called " + i);
        }
        public static void Main(string[] args)
        {
            defaultcondemo de = new defaultcondemo();

        }
    }
}
