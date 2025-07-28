using System;
using System.Xml.Schema;
class Satya
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Telugu Marks");
        int Tel= int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Hindi Marks");
        int Hin = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter English Marks");
        int Eng=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Maths Marks");
        int Mat = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Science Marks");
        int sci = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Social Marks");
        int Soc = int.Parse(Console.ReadLine());
        // marks Validation
        if (Tel <= 35 && Hin <= 35 && Eng <= 35 && Mat <= 35 && sci <= 35 && Soc <= 35)
        {


            // total marks
            int total = (Tel + Hin + Eng + Mat + sci + Soc);
            Console.WriteLine("your total marks :" + total);
            // percentage calculation
            var Actual_Marks = 600;
            Double Percentage = (total * 100) / Actual_Marks;
            Console.WriteLine("Your Percentage is :" + Percentage);

        }
        else
        {
            Console.WriteLine("failed in one or more Subjetcs");
        }

        



    }
}