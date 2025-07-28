using System;

class Satya
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Telugu Marks");
        int Tel = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Hindi Marks");
        int Hin = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter English Marks");
        int Eng = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Maths Marks");
        int Mat = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Science Marks");
        int Sci = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Social Marks");
        int Soc = int.Parse(Console.ReadLine());

        //total marks

        if (Tel <= 35 && Hin <= 35 && Eng <= 35 && Sci <= 35 && Soc <= 35 && Mat < 35)
        {
            Console.WriteLine("all subjects are Passed");

            int Total_marks = (Tel + Hin + Eng + Mat + Sci + Soc);
            Console.WriteLine("total marks obtained:" + Total_marks);
            var Actual_marks = 600;
            int Percentage = (Total_marks*100)/Actual_marks;
            Console.WriteLine("percentage");


        }

    }
}