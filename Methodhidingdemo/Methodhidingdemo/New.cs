using System;

class demo
{
    public void display()
    {
        Console.WriteLine("This is  demo Display Method");
    }
    public void display2()
    {
        Console.WriteLine("satyasai");
    }
}
class demo1:demo
{
    public void display()
    {
        Console.WriteLine("This is demo1 display method ");
        
    }
    public static void Main(string[] args)
    {
        demo d = new demo1();
        d.display();
        
        
    
        
        
    }
}