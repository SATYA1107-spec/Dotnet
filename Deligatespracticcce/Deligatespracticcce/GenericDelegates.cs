using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligatespracticcce
{
    public class GenericDelegates
    {
        public static void Main(string[] args)
        {
            Func<double, double, int> rec = (double x, double y) => Convert.ToInt32(x * y); Console.WriteLine(rec.Invoke(2.3, 4.4));
            Action<double> sq = (double a) => Console.WriteLine(a * a);sq.Invoke(2);
            Predicate<string> bl = (string a) => a.Length > 3; Console.WriteLine(bl.Invoke("satya"));

           
        }

    }

}
