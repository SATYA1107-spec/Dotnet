using System;
using System.Threading;
class Joint_Acc
{
    public static void Main(string[] args)
    {
        
    }
}
class Transactions
{
    int Account_Balance = 1000;
   public void deposit(string name , int amount)
    {
        Console.WriteLine($"{name} is trying to deposit amount {amount}");
        Account_Balance += amount;
        Console.WriteLine($"updated balance is {Account_Balance}");
    }
   public void Withdraw(string name , int amount)
    {
        if ()
        Console.WriteLine($"{name} is trying to Withdraw amount {amount}");
        Account_Balance -=amount;
        Console.WriteLine($"updated balance is {Account_Balance}");
    }
}
class Program
{
    Transactions tra;

     void user1()
    {
        tra.deposit
    }

}