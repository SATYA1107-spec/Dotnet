using System;

class StudentDetails
{
    public  String Roll = "17A25A0244";
    public  Char Gender = 'M';
    public  char BG = 'A';
    public  string Name = "satyasai";

    public void Student()
    {
        Console.WriteLine("Please enter Student Details");
    }
    public int Add(int a, int b)
    {
        return a+b;
    }
}

class Methods
{
    public static void Main(string[] args)
    {
        int ph = 321;
        StudentDetails s = new StudentDetails();
        s.Student();
        Console.WriteLine("Student roll number is " + s.Roll);
        Console.WriteLine("student gender is " + s.Gender);
        Console.WriteLine("student Name is " + s.Name);
        Console.WriteLine("student Blood Group is " + s.BG);
        Console.WriteLine("sum-1 " + s.Add(20, 30));
        Console.WriteLine("sum-2 " + s.Add(30, 40));
        Console.WriteLine(ph);

      
  
    }
}