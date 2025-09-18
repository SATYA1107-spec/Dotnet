using System;

using System.Collections.Generic;

class ListExample
{
    public static void Main(string[] args)
    {
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(20);
        list.Add(32);
        list.Add(44);
        list.Add(51);
        list.Add(66);
        list.Add(73);
        list.Add(32);
        foreach (int i in list)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("==============================");

        HashSet<int> set = new HashSet<int>();
        set.Add(1);
        set.Add(20);
        set.Add(32);
        set.Add(44);
        set.Add(51);
        set.Add(66);
        set.Add(73);
        set.Add(32);

        foreach (int i in set)
        {
            Console.WriteLine(i);
        }

    }
}