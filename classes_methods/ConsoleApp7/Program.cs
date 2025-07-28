using System;

class StudentDetails
{
    public static String Roll = "17A25A0244";
    public static Char Gender = 'M';
    public static char BG = 'A';
    public static string Name = "satyasai";

    public static void Student()
    {
        Console.WriteLine("Please enter Student Details");
    }
    public static int Add(int a, int b)
    {
        return a+b;
    }
}

class Methods
{
    public static void Main(string[] args)
    {
        StudentDetails.Student();
        Console.WriteLine("Student roll number is " + StudentDetails.Roll);
        Console.WriteLine("student gender is " + StudentDetails.Gender);
        Console.WriteLine("student Name is " + StudentDetails.Name);
        Console.WriteLine("student Blood Group is " + StudentDetails.BG);
        Console.WriteLine("sum-1 " + StudentDetails.Add(20, 30));
        Console.WriteLine("sum-2 " + StudentDetails.Add(30, 40));

      
  
    }
}