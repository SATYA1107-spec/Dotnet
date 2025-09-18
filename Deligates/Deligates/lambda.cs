using System;

namespace Delegates
{
    public delegate int anonydem(int a, int b);
    class Anonomyous
    {
        static void Main()
        {

            anonydem obj = (int a, int b) => a + b;
     
            int sa = obj.Invoke(2,3);

            Console.WriteLine(sa);


        }
    }
}

