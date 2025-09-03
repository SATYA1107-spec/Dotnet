using System;
using System.Threading;
class Joint_Acc
{
    public static void Main(string[] args)
    {
       Program program = new Program();

        Thread u1 = new Thread(program.user1);
        Thread u2 = new Thread(program.user2);
        u1.Start();
        u2.Start();
    }
}
class Transactions
{
   object balance = new object();
   int Account_Balance = 10000; 
   public void deposit(string name , int amount)
    {
        lock (balance)
        {
            Console.WriteLine($"{name} is trying to deposit amount {amount}");
            Account_Balance += amount;
            Console.WriteLine($"updated balance is {Account_Balance}");
        }
    }
   public void Withdraw(string name , int amount)
    {
        lock (balance)
        {
            if (amount <= Account_Balance)
            {
                Console.WriteLine($"{name} is trying to Withdraw amount {amount}");
                Account_Balance -= amount;
                Console.WriteLine($"updated balance is {Account_Balance}");
            }
            else
            {
                Console.WriteLine("In Sufficient Funds");
            }
        }
    }
}
class Program
{
    Transactions tra = new Transactions();
    public void user1()
    {
        tra.deposit("satya", 500);
        tra.Withdraw("satya", 200);
    }
     public void user2()
    {
        tra.deposit("Geethika", 5000);
        tra.Withdraw("Geethika", 2000);
    }

    
}