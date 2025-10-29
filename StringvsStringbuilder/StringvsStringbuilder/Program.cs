using System;
using System.Text;

class Demo
{
    public static void Main(string[] args)
    {
        string s = "satyasai";
        Console.WriteLine(s.GetHashCode());
        s += "bhimavaram";
        Console.WriteLine(s.GetHashCode());
        s += "naidu";
        Console.WriteLine(s.GetHashCode());

        Console.WriteLine("------------------------------------");

        StringBuilder sb = new StringBuilder("satya");
        Console.WriteLine(sb.GetHashCode());
        sb.Append("sai");
        Console.WriteLine(sb.GetHashCode());
        sb.Append("bhimavaram");
        Console.WriteLine(sb.GetHashCode());

           

    }
}