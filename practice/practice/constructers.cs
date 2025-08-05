using System;

class Const
{
    public int age;
    public int id;

    public  Const(int age, int id)
    {
        this.age = age;
        this.id = id;
    }
}
class demo
{
   public static void Main(string[] args)
    {
        Const con = new Const(24, 345);
    }
}