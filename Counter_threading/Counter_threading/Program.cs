using Microsoft.VisualBasic;
using System;
using System.Collections;

class Coll
{
    public static void Main(string[] args)
    {
        ArrayList c1 = new ArrayList();

        c1.Add(12);
        c1.Add("satya");
        c1.Add(3.4);
        c1.Add(4000000000000);
        c1.Add(true);
        c1.Add('m');
        Console.WriteLine(c1[0]);

        for (int i = 0; i < c1.Count; i++)
        {
           
            Console.WriteLine(c1[i]);  
        }
            

    }
}