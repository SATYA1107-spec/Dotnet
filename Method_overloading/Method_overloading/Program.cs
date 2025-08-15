
using System;
using System.Data;

class A
{
    public void sum(string a)
    {
        Console.WriteLine(a);
    }
   
    public void sum(int a, int b)
    {
        Console.WriteLine(a * b);
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
        sa.sum(10.2D, 5.2D);
        sa.sum("satya");
        sa.sum(3, 7);
    }
}