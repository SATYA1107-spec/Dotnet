using System;
using System.Diagnostics.CodeAnalysis;

class Test
{
    public static void Main(string[] args)
    {
        int a = 40;
        int b = 20;
        int sum = a + b;
        int sub = a - b;
        int div = a / b;
        int rem = a % b;
        Console.WriteLine(" "+sum+" \n "+sub+" \n "+div+" \n "+rem);
    }
}