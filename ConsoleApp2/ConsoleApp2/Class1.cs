using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class DoWhileExmample
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <=5 ; i++)
        {
            for (int j = 1; j <= i ; j++)
            {
                Console.Write(i+ "");
            }
            Console.WriteLine();
        }
    }
        
}