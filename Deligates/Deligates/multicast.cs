using System;

namespace MulticastDemo
{
    public delegate int MulDel (int a, int b);
    class Multicast
    {
        public static void Main(string[] args)
        {

            MulDel sa = new MulDel(add);
          
            sa += Statement;
            sa += Display;

             int x = add(2, 3);
            int y = Statement(2,4);
            int z = Display(2,2);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

        }
        public static int add(int x, int y)
        {
            return x + y;

        }
        
        public static int  Statement (int x, int y)
        {
            return x-y;
        }
       public  static int  Display(int a , int b)
        {
            return a * b;
        }
    }
}