using System;
using System.Diagnostics;
using System.Threading;
using System.Timers;

class Async_Await
{
    static async Task test()
    {
        Stopwatch sw = new Stopwatch();
        Console.WriteLine("Async method started ");
        sw.Start();
        await Task.Delay(1000);
        sw.Stop();
        Console.WriteLine("Async method ended ");
        Console.WriteLine(sw.ElapsedMilliseconds);
    }
    static async Task Main(string[] args)
    {
        Console.WriteLine("main method started ");
        await test();
        Console.WriteLine("main method ended here");
    }
}