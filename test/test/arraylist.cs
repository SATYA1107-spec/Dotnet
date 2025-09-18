using System;
using System.Collections;

class Arraylist
{
    public static void Main(string[] args)
    {
       ArrayList list = new ArrayList();
        list.Add(1);
        list.Add("satya");    
        list.Add(3.45);
        list.Add(true);

        Console.WriteLine(list[1]);

        foreach(var i in list)
        {
            Console.WriteLine(i);
        }
        
        
    }
}