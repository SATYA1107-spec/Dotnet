using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;


class Employee
{
    public static int id = 14234;
    public static string name = "surya";
    public static char gender = 'm';
    public static char blood_group = 'A';

   public static void Display()
    {
        Console.WriteLine("Better luck next time");
    }

}
class Satya
{
public static void Main(string[] args)
    {
      
        Console.WriteLine(Employee.id);
        Console.WriteLine(Employee.name);
        Console.WriteLine(Employee.gender);
        Console.WriteLine(Employee.blood_group);
        Employee.Display();
        
    }

}