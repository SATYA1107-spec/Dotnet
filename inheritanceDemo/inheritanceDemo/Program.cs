


using System;

namespace Inheritancedemo
{
    class test1
    {
        public test1(int i)
        {
            Console.WriteLine("this is class a constructor" +i);
        }
        public void method1()
        {
            Console.WriteLine("method1");
        }
        public void method2()
        {
            Console.WriteLine("method2");
        }
    }
    class test2 :test1
    {
        test2(int a):base(a)
        {
            Console.WriteLine("this is test 2 constructor");
        }
        public void method3()
        {
            Console.WriteLine("method3");
        }
        public static void Main(string[] args)
        {
          test2 test = new test2(10);
            
           
        }
    }

}