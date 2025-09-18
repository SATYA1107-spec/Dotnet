using System;
using System.Threading;
using System.Threading.Tasks;

class Test
{
    public static async Task Main(string[] args)
    {
        Demo demo = new Demo();
        Console.WriteLine("main method started");
        await Demo.sat("yaragogu", "satyasai");
        Console.WriteLine("main method ended ");
       
    }

}
class Demo
{
    public static async Task<string> sat(string fristname, string secondname)
    {
        Console.WriteLine($"{fristname} {secondname}");
        await Task.Delay(1000);
        return fristname + secondname;
      
    }
}
