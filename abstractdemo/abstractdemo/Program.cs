using System;
using System.Security.Cryptography.X509Certificates;

namespace abs
{
    abstract class absparent
    {
        public static void add(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        public static void sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public  abstract void mul(int x, int y);
        public  abstract void div(int x, int y);

    }
    class abschild : absparent
    {
        public override void mul(int x, int y)
        {
            Console.WriteLine(x*y);
        }
        public override void div(int x, int y)
        {
            Console.WriteLine(x/y);
        }
        public static void Main(string[] args)
        {
            abschild.add(100, 200);
            abschild.sub(1000, 200);
            abschild c = new abschild();
            absparent p = c;
            p.mul(100, 200);
            p.div(1000, 200);
            

        }
    }
}