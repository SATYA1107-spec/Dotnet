using System;
using System.Collections;

class Hashtabledemo
{
    public static void Main(string[] args)
    {
        Hashtable ht = new Hashtable();
        ht.Add("name", "satya");
        ht.Add("id", 234); 
        ht.Add("phone no", 9949568789);
        ht.Add("village", "chanamilli"); 
        ht.Add("District", "West godavari");
        ht.Add("state", "Andhara pradesh");
        ht.Add("pincode", 534198);


        foreach (DictionaryEntry s in ht)
        {
            Console.WriteLine(s);
        }
        
    }
}