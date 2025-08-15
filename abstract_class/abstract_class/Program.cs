using System;
using System.Numerics;

 abstract class A
{
    public int x = 23;
    public int y  =45;
    public abstract void Math();

    public void display(int x, int y)
    {
        Console.WriteLine(x*y);
    }

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
        b.display(4,5);
       
    }

}