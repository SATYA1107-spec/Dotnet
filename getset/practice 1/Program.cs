using System;

class Atm
{
    private int pin;

    public int Pin
    {
        get { return pin; }
        set
        {
            if (pin != value)
            {
                pin = 1714;
            }
            else
            {
                pin = value;
            }

               
        }
    }

   
}

class Program
{
    static void Main(string[] args)
    {
        Atm aa = new Atm();
        aa.Pin = 2714;
        Console.WriteLine(aa.Pin);
    }
}