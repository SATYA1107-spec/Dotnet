using System;
using System.Threading;

class Demo
{
    public static void Main(string[] args)
    {
        Booking booking = new Booking();
        Thread t1 = new Thread(() => booking.user(20, "satya", 4));
        Thread t2 = new Thread(() => booking.user(27, "bobby", 2));
        Thread t3 = new Thread(() => booking.user(18, "navya", 1));
        Thread t4 = new Thread(() => booking.user(70, "geethika", 3));
        t1.Start();
        t2.Start();
        t3.Start();
        t4.Start();

        t1.Join();
        t2.Join();
        t3.Join();
        Display();

        void Display()
        {
            Console.WriteLine("All tickets booked Successfully");
        }
    }
}
class Booking
{
    int available_Tickets = 10;
    public void user(int age, string name, int required_tickets)
    {
        lock (this)
        {
            if (required_tickets <= available_Tickets)
            {
                if (age > 60)
                {
                    Console.WriteLine($"{name} is availible to book lower tickets");
                }

                Console.WriteLine($"{name} booked {required_tickets} successfully");
                Console.WriteLine($"Availible tickets :{available_Tickets -= required_tickets}");
            }
            else
            {
                Console.WriteLine($"{name} is unable to book tickets");
            }
        }
    }
}
