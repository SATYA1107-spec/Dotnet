using System;

class Str
{
    public static void Main(string[] args)
    {
        string s = "satyasai";

        string rev = "";

        for (int i = 0; i < s.Length; i++)
        {
            rev = s[i] + rev;
           
        }
        Console.WriteLine(rev);


    }
}