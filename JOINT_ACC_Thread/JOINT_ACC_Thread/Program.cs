using System;
using System.Threading;
using System.Transactions;

class Joint_Account
{
    public static void Main(string[] args)
    {
        Withdraw wa = new Withdraw();
        Thread p1 = new Thread(wa.satya);
        Thread p2 = new Thread(wa.sai); 
        p1.Start();
        p2.Start();
    }
}
class Withdraw
{
    int Account_Balance = 5000;
    public void satya()
    {
        lock (this)
        {
            Console.WriteLine("Satya is Withdrawing money");

            Console.WriteLine($"Availible balance in your Account is : {Account_Balance}");

            Console.Write("Enter Required Amount ");
            int Required_amount = int.Parse(Console.ReadLine());

            if (Required_amount <= Account_Balance)
            {
                Console.WriteLine($"satya is trying to withdraw Amount {Required_amount}");
                int Remaining_balance = Account_Balance - Required_amount;
                Console.WriteLine($"Amount Withdrawal Successfull , remaining balance is {Remaining_balance}");
                Account_Balance = Remaining_balance;
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("Insufficent Funds in your account");
            }
        }
    }
    public void sai()
    {
        lock (this)
        {
            Console.WriteLine("sai is withdrawing Money");
            Console.WriteLine($"Availible balance in your Account is : {Account_Balance}");
            Console.Write("Enter Required Amount ");
            int Required_amount1 = int.Parse(Console.ReadLine());
            if (Required_amount1 <= Account_Balance)
            {
                Console.WriteLine($"Amount Withdrawal Successfull , remaining balance is {Account_Balance -= Required_amount1}");
            }
            else
            {
                Console.WriteLine("Insufficent Funds in your account");
            }
        }
    }
}