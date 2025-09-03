using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

class Async
{
    public static async Task Main(string[] args)
    {
        Demo de = new Demo();
        Stopwatch s1 = new Stopwatch();

        s1.Start();
        Console.WriteLine("main method started here ");
        int res = await de.test(10, 20);
        Console.WriteLine("main method ended here and printing the return sum of values "+res);
        s1.Stop();
        Console.WriteLine(s1.ElapsedMilliseconds);
    }

}
class Demo
{

    public async Task <int> test(int a, int b)
    {
        Console.WriteLine("test method started here and return the values to main method");
        await Task.Delay(5000);
        return a + b;

    }
}