using System;

namespace DeligatesDemo
{
    public delegate void adddeligate(int x, int y);
    public delegate string Displaydeligate(string name);
    public delegate void method();
    class DeligatesDemo
    {
        public static void Main(string[] args)
        {
           adddeligate ad = new adddeligate(Add);
            ad.Invoke(2, 3);
            Displaydeligate dd = new Displaydeligate(Display);
            Console.WriteLine(dd.Invoke("satya"));
            method sa = new method(demo.demomethod);
            sa.Invoke();

        }

       static public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

       static string Display(string name)
        {
            return "hello "+ name;  
        }
    }
    class demo
    {
        public static void demomethod()
        {
            Console.WriteLine("this is demo method");
        }
    }
}