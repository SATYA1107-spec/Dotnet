using System;

class demo
{
    public void demomethod()
    {
        Console.WriteLine("this is Parent class method ");
    }
}
class demo1 : demo
{
    public void demo1method()
    {
        Console.WriteLine("This is child class method ");
    }
    public static void Main(String[] args)
    {
        demo1 de1 = new demo1();
        demo d1 = de1;
    }
}


