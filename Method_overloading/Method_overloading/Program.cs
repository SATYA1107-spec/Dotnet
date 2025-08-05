
using System;

class A
{
    public void sum(string a)
    {
        Console.WriteLine(a);
    }
}
class B : A
{
    public void sum(double a, double b)
    {
        Console.WriteLine(a - b);
    }
}
class M_overloading
{
    static void Main(string[] args)
    {
        B sa = new B();
        sa.sum(2.2, 3.3);
        sa.sum("satya");
    }
}