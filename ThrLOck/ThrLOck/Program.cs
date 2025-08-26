using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;

class ThreadLock
{
    void Dispaly()
    {
        lock (this)
        {
            Console.Write("The code has been ");
            
            Thread.Sleep(2000);
            Console.WriteLine("Running");
        }
    }

    public static void Main(string[] args)

    { 
        ThreadLock th = new ThreadLock();
        Thread t1 = new Thread(th.Dispaly);
        Thread t2 = new Thread(th.Dispaly);
        t1.Start();
        t2.Start();
    }

    

}