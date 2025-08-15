using System;

interface prime_Number
{
   public void Number();
}
class A : prime_Number
{
    public void Number()
    {
        Console.WriteLine("enter  any number");
        int n =int .Parse(Console.ReadLine());
        if (n % 2 == 0)
        {
            Console.WriteLine("Entered number is Prime number");
        }
        else
        {
            Console.WriteLine("given number is not a prime number");
        }
        

    }
}
class B : prime_Number
{
    public void Number()
    {
        Console.WriteLine("enter odd number");
        int o =int .Parse(Console.ReadLine());
        if (o % 2 != 0)
        {
            Console.WriteLine("entered number is odd number");
        }
        else
        {
            Console.WriteLine("entered number is not a odd number "+o);
        }
    }
}

class Satya
{
    public static void Main(string[] args)
    {
        A a = new A();
        B b = new B();

        a.Number();
        b.Number();
    }
}