using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Deligatespracticcce
{
    public delegate double arearec(double a , double b);
    public delegate void areasqr(double s);
    public delegate bool Strlgh(string  s);
  
    class Program
    {
        public static void Main(string[] args)
        {
            arearec ar = (double x, double y) => x * y; Console.WriteLine(ar.Invoke(2,2));
            Console.WriteLine("----------");
            areasqr asq = (double s) => Console.WriteLine(s * s);asq.Invoke(3);
            Console.WriteLine("----------");
            Strlgh sl = (string s) => s.Length > 5; Console.WriteLine(sl.Invoke("satya sai"));
        }
    }
}
