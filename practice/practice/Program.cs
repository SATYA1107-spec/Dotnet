using System;

interface A
{
    public void glass();
}
interface B
{
    public void plate();
}
public class C
{
    public void Spoon()
    {
        Console.WriteLine("this is C class");
    }
} 
public class D: C, A
{
    public void spoon()
    {
        Console.WriteLine("THIS IS INHERITED from class C");
    }
    public void glass()
    {
        Console.WriteLine("THIS IS INHERITED from class A ");
    }
}
public class E : D, B, A
{
    public void plate()
    {
        Console.WriteLine("This is inherited from class B ");
    }

}

class Demo

{
    static void Main(string[] args)
    {
        C c = new C();
        D d = new D();
        E e = new E();

        c.Spoon();
        d.Spoon();
        d.glass();

    }
}