using System;

class SwitchExpDemo
{
    static void Main(string[] args)
    {
        Console.Write("Enter week number : ");
        int n = Convert.ToInt32(Console.ReadLine());

        var result = n switch
        {
            0 => "monday",
            1=>"tuesday",
            2=>"wednesday",
            3=>"thursday",
            4=>"friday",
            5=>"Saturday",
            6=>"sunday",
            _=>"not able to display"

        };
        Console.WriteLine(result);
    }
}