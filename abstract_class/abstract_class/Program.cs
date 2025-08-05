using System;
using System.Numerics;

 abstract class A
{
    public int x = 10;
    public int y = 20;
    public abstract void Math();

}
class B: A
{
    public override void Math()
    {
        Console.WriteLine("addition of two number : " + (x+y));
    }
}
class C : A
{
    public override void Math()
    {
        Console.WriteLine("subtraction of two numbers is : " + (y-x) );
    }
}

class Program
{
    public static void Main(string[] args)
    {
        B b = new B();
        C c = new C();

        b.Math();
        c.Math();
    }
}