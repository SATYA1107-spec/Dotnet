using System;

class Calc
{
    public Calc(int a, int b)
    {
        Console.WriteLine("this is integer method :" + (a + b));
    }
    public Calc(double a, double b)
    {
        Console.WriteLine("this is Double method :" + (a + b));
    }
}
class Cons_ovldg
{
    static void Main(string[] args)
    {
        Calc we = new Calc(2.5, 2.54566);
        Calc ds = new Calc(2, 3);
    }

}