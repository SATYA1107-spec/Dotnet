using System;
using System.Numerics;

namespace OppDemo
{
    class OppTest
    {
        public int a {  get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public int d { get; set; }

        public OppTest(int a , int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
       public static OppTest operator+(OppTest x, OppTest y)
        {
            return new OppTest((x.a + y.a), (x.b + y.b), (x.c + y.c), (x.d + y.d));
        }

        public override string ToString()
        {
            return a + " " + b + " \n" + c + " " + d+"\n"; 
        }

        public static void Main(string[] args)
        {
            OppTest op1 = new OppTest(20, 10, 30, 50);
            OppTest op2 = new OppTest(10,20,0,10);
            OppTest op3 = op1 + op2;
            Console.WriteLine(op1);
            Console.WriteLine(op2);
            Console.WriteLine(op3);
        }
    }
}