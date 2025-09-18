using System;
using System.Security.Cryptography.X509Certificates;
namespace demo
{
    class func_predict_action
    {
        public static void Main(string[] args)
        {
            Func<int, float, double> ad1 = (int a, float b) =>(a + b);Console.WriteLine(ad1.Invoke(2, 4.44f));
            Action<int, float> ad2 = (int a, float b) => Console.WriteLine(a + b);ad2.Invoke(2, 4.44f);
            Predicate<string> che = (string name) => name.Length > 5; Console.WriteLine(che.Invoke("Geethika aunty"));
        }    
    } 
}