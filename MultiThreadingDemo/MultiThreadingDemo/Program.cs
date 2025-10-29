using System;

namespace MulthrDemo
{
    class Multithreadingdemo
    {
        public static void test1()
        {
            for(int i =1;i<10;i++)
            {
                Console.WriteLine("Test 1 :"+i);
            }
        }
        public static void test2()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Test 2 :" + i);
            }
        }
        public static void test3()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Test 3 :" + i);
            }
        }
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(test1);
            Thread t2 = new Thread(test2);
            Thread t3 = new Thread(test3);
            Console.WriteLine(Thread.CurrentThread);
            t1.Start();
            t2.Start();
            t3.Start(); 
        }
    }
}