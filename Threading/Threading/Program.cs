using System;
using System.Threading;
using System.Threading.Channels;

class Sample
{
    public static void Main(string[] args)
    {
        Thread th = Thread.CurrentThread;
        th.Name = "Main_thread";
      // Thread t1 = new Thread(upcount);
      //  Thread t2 = new Thread(Downcount);
      //  t1.Start();
      //  t2.Start();
       Console.WriteLine($"{th.Name} Completed");
        upcount();
        Downcount();


    }

    static void upcount()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("UPcount Thread" + i);
            
        }
        Console.WriteLine("upcount thread Completed");
    }
    static void Downcount()
    {
        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine("DownCount Thread"+ i);
           
        }
        Console.WriteLine("downcount thread completed");
    }
    
}
