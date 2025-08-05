using System;

class A
{
    public int id = 2445;
    public string name = "satya";

    public virtual void message()
    {
        Console.WriteLine("This is parent class");
    }

}
class B : A
{
    public long number = 63032589878;
    public char Gender = 'M';

    public override void message()
    {
        Console.WriteLine("This is child class");
    }
}
class Satya
{
    public static void Main(string[] args)
    {
        
        A a = new B();
        a.message();
    }
}