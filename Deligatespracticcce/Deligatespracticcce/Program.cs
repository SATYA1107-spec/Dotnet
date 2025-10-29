using System;

namespace DelegatesDemo
{
    public delegate void Add(int a, int b);
    public delegate string Dis(string  s);
    class DelDemo
    {
        public static void AddDel(int x, int y)
        {
            Console.WriteLine($"AddDel value is :{x + y}");
        }
        public static void  SubDel(int x, int y)
        {
            Console.WriteLine($"SubDel value is : {x - y}");
        }
        public  string Display(string name)
        {
            return name;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            DelDemo dd = new DelDemo();
            Add aa = new Add(DelDemo.AddDel);
            aa += DelDemo.SubDel;
            aa.Invoke(10, 30);
            Dis ds = new Dis(dd.Display);
           string d=  ds("satya");
            Console.WriteLine(d);
           
        }

    }
}