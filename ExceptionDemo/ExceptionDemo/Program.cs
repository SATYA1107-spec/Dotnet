using System;

class demo
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("enter a value : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter b value : ");
            int b = Convert.ToInt32(Console.ReadLine());
            if(b == 0)
            {
                throw new Exception("cant divide by zero");
            }
            int c = a / b;
            Console.WriteLine(c);
   
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("this is finally block");
        }
    }
}