using System;
using System.Threading.Tasks;

class AsyncDemo
{
    public async Task DataSending()
    {
        Console.WriteLine("Data sending Started............");
        await Task.Delay(1000);
        Console.WriteLine("Data sending completed...........");
    }
    public static async Task Main(string[] args)
    {
        AsyncDemo demo = new AsyncDemo();
        Console.WriteLine("Main method started........");
        await demo.DataSending();
        Console.WriteLine("main method ended.......");
    }
}