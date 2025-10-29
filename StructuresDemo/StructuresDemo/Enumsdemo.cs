using System;

public enum Days : byte
{
    sunday = 1, monday= 23, tuesday = 34,wednesday = 29, thursday= 56, friday = 45,saturday= 50
}
public class Enumsdemo
{
    public static Days MeetingDate {  get; set; }= Days.sunday;
    public static void Main(string[] args)
    {
        Console.WriteLine(MeetingDate);
        MeetingDate = Days.wednesday;
        Console.WriteLine(MeetingDate);

        int value = (int)MeetingDate;
        Console.WriteLine(value);

        
    }
}

       
  
