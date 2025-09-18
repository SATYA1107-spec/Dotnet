using System;
using System.Collections;

class Sorteddemo
{
    static void Main()
    {

        Console.WriteLine("This is non generic");
        SortedList dt1 = new SortedList();
        dt1.Add("name", "satya");
        dt1.Add("id", 234);
        dt1.Add("phone no", 9949568789);
        dt1.Add("village", "chanamilli");
        dt1.Add("District", "West godavari");
        dt1.Add("state", "Andhara pradesh");
        dt1.Add("pincode", 534198);

        foreach (DictionaryEntry s in dt1)
        {
            Console.WriteLine(s);
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("This is Generic");

        Dictionary<string, string> dt = new Dictionary<string, string>();
        dt.Add("name", "satya");
        dt.Add("id", "234");
        dt.Add("phone no", "9949568789");
        dt.Add("village", "chanamilli");
        dt.Add("District", "West godavari");
        dt.Add("state", "Andhara pradesh");
        dt.Add("pincode", "534198");

        foreach (KeyValuePair<string, string> s in dt)
        {
            Console.WriteLine(s);
        }
    }

}