using System;

struct StructuresDemo
{
    int i;
    public void Display()
    {
       
        Console.WriteLine("This is display method "+i);
    }
    public static void Main(string[] args)
    {
        StructuresDemo s1;
        s1.i = 1;
        s1.Display();
    }
}