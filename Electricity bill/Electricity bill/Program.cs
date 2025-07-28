// Calculate Electricity bill using Units consumed

using System;

class Electricty_bill
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Number of units consumed");
        int units = int.Parse(Console.ReadLine());

        /*Category 1(between - 0to 100)
0-50 Units - ₹1.45 consumer charges : 25₹
51-100 units - ₹ 2.60 consumer charges : 30₹

Category 2(between - 100 to 200)
0-100 Units - ₹3.30 consumer charges : ₹50
101-200 units - ₹ 4.30 consumer charges : 50₹
Category 3(more than 200 units)
0-200 Units - ₹5 consumer charges : ₹60
201-300 units - ₹ 7.20 consumer charges : ₹60
301-400 units - ₹ 8.50 consumer charges : ₹80
401-800 units - ₹ 9 consumer charges : ₹80
Above 800 Units - ₹ 9.5 consumer charges : ₹80*/
       
        if (units <= 50)
        {
            var Fixed_charges = 25;
            Double bill = (units * 1.45);
            Double total = (bill +  Fixed_charges);
            Console.WriteLine("Your electricity bill is:"+total);
        }
        else if (units >=51 && units <= 100)
        {
            var Fixed_charges = 30;
            Double bill = (units * 2.60);
            Double total = (bill + Fixed_charges);
            Console.WriteLine("Your electricity bill is:" + total);
        }
        else if (units >= 100 && units <=200)
        {
            var Fixed_charges = 50;
            Double bill = (units * 4.30);
            Double total = (bill + Fixed_charges);
            Console.WriteLine("Your electricity bill is:" + total);
        }
        else if (units >= 200 && units <= 300)
        {
            var Fixed_charges = 60;
            Double bill = (units * 7.20);
            Double total = (bill + Fixed_charges);
            Console.WriteLine("Your electricity bill is:" + total);
        }
        else if (units >= 300 && units <= 400)
        {
            var Fixed_charges = 80;
            Double bill = (units * 8.50);
            Double total = (bill + Fixed_charges);
            Console.WriteLine("Your electricity bill is:" + total);
        }
        else if (units >= 400 && units <= 800)
        {
            var Fixed_charges = 80;
            Double bill = (units * 9);
            Double total = (bill + Fixed_charges);
            Console.WriteLine("Your electricity bill is:" + total);
        }
        else if (units >= 900)
        {
            var Fixed_charges = 80;
            Double bill = (units * 9.50);
            Double total = (bill + Fixed_charges);
            Console.WriteLine("Your electricity bill is:" + total);
        }

    }
}