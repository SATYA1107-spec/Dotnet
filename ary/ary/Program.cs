using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

class ary
{
    public static void Main(string[] args)
    {
        ArrayList ar = new ArrayList();
        ar.Add(1);
        ar.Add(2);
        ar.Add(1);
        ar.Add(4);
        ar.Add(7);
        ar.Add(1);
        ar.Add(7);
        ar.Add(2);
        Console.WriteLine(ar[0]);

        
    
        foreach (int i in ar)
        {
            Console.WriteLine(i); 
        }
       
            
    }
}