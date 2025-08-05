using System;

class StudentDetails
{
    public static string name = "satya";
    public static int id = 234;
    public static char Gender = 'm';
    public static String Blood_Group = "A+";

    public static int add(int x , int y)
    {
        
        
    }
}

class Test
{
    public static void Main(String[] args)
    {
        int age = 27;
        Console.WriteLine(StudentDetails.id);
        Console.WriteLine(StudentDetails.name);
        Console.WriteLine(StudentDetails.add(10,40));
        Console.WriteLine("age "+age);

    }
}