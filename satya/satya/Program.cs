using System;
class Satya
{
    public static void Main(string[] args)
    {
        DateTime dateTime = DateTime.Now;


        int day = dateTime.Day;
        int month = dateTime.Month;
        int year = dateTime.Year;

        
        Console.WriteLine($"{day}/{month}/{year} ");
    }
}