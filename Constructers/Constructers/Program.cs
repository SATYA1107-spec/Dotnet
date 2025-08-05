using System;
class Const
{
    public void Const(int a, int b)
    {
        Console.WriteLine(a+b);
    }
   
}
class Dem
{
    public static void Main(string[] args)
    {
        Const con = new Const();
        con.Const(4,5);
   
    }
}