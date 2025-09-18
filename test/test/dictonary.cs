using System;
using System.Collections;

class Dictonarydemo
{
    public static void Main(string[] args)
    {
        Dictionary<object,object> dt = new Dictionary<object,object>();   
        dt.Add("name", "satya");
        dt.Add("id", 234);
        dt.Add("phone no", 9949568789);
        dt.Add("village", "chanamilli");
        dt.Add("District", "West godavari");
        dt.Add("state", "Andhara pradesh");
        dt.Add("pincode", 534198);
        Console.WriteLine(dt["village"]);
        foreach (KeyValuePair <object,object> s in dt)
        {
            Console.WriteLine(s);
        }

    }
}