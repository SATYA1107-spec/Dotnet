using System;
using System.Threading;

class MonitorExample
{
    private static readonly object obj = new object();
    private static int count = 0;

    public static void Increment()
    {
        bool lockTaken = false;
        try
        {
            Monitor.Enter(obj, ref lockTaken);
            count++;
            Console.WriteLine($"Count = {count}");
        }
        finally
        {
            if (lockTaken) Monitor.Exit(obj);
        }
    }

    public static void Main()
    {
        for (int i = 0; i < 5; i++)
            new Thread(Increment).Start();
    }
}
