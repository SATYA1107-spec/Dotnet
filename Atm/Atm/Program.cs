using System;
using System.Timers;

class ATM
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter ATM Pin");
        int pin1 = int.Parse(Console.ReadLine());
        Double Balance = 70000;
        int Pin = 1714;
        if ( pin1 == Pin)
        {
            Console.WriteLine("Welcome to ICICI Bank");
            Console.WriteLine("Enter your choice:\n1.Withdraw\n2.Deposit\n3.Ministatement\n4.Generate Pin");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine("Enter your Withdraw Amount");
                double Withdraw_Amount = double.Parse(Console.ReadLine());
                if ( Withdraw_Amount <= Balance)
                {
                    if ( Withdraw_Amount%100==0)
                    {
                        if( Withdraw_Amount <= 20000)
                        {
                            Console.WriteLine("please collect cash, availible balance is:" + (Balance - Withdraw_Amount));
                        }
                        else
                        {
                            Console.WriteLine("unable to dispense cash more than 20,000");
                        }
                    }
                    else
                    {
                        Console.WriteLine("please enter 100s");
                    }
                }
                else
                {
                    Console.WriteLine("entered amount is more than the availible balance");
                }

            }
            else
            {
                if ( option == 2)
                {
                    Console.WriteLine("Enter Deposit Amount");
                    double Deposit = double.Parse(Console.ReadLine());

                    Console.WriteLine("please place cash in the Machine");

                }
            }

        }
        else
        {
            Console.WriteLine("Incorrect pin Entered, Please enter correct pin");
            Console.WriteLine("Enter ATM Pin");
            int pin2 = int.Parse(Console.ReadLine());
            if ( pin2 == Pin)
            {
                Console.WriteLine("Write code");
            }
            else
            {
                Console.WriteLine("Incorrect pin Entered, Please enter correct pin");
                Console.WriteLine("Enter ATM Pin");
                int pin3 = int.Parse(Console.ReadLine());
                if (pin3 == Pin)
                {
                    Console.WriteLine("Write code");

                }
                else
                {
                    Console.WriteLine("Your card is blocked");
                }
            }
        }
    }
}