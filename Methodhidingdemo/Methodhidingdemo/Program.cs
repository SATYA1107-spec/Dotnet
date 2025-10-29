using System;

class employee
{
    public virtual void  show()
    {
        Console.WriteLine("this is base class Show method ");
    }
    public void empdata()
    {
        Console.WriteLine("this is base class empdata method");
    }
}
class Student : employee
{
    public override void show()
    {
        employee e1 = new employee();
        e1.show();
        base.empdata();
    }

    public  new void empdata()
    {
      employee e1 = new employee();
        e1.show();
        base.empdata();
    }
    public static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.empdata();
        s1.show();
    }
}
