using System;
using System.Text;

namespace Interfacedemo
{
    interface Testinterface1
    {
        
         public void Car(int speed, string Model_name, int Milage);
    }
    interface Testinterface2:Testinterface1
    {
        void Bike(int speed, string Model_name, int Milage);
    }
    class Implimentationclass:Testinterface2
    {
          public void Car(int speed, string Model_name, int Milage)
        {
            Console.WriteLine($" This speed of the Car is {speed} and model name is {Model_name} and the milage {Milage}");
        }
         void Testinterface2.Bike(int speed, string Model_name, int Milage)
        {
            Console.WriteLine($" This speed of the Bike is {speed} and model name is {Model_name} and the milage {Milage}");
        }
        public static void Main(string[] args)
        {
            Implimentationclass ic = new Implimentationclass();
            ic.Car(200, "rangerover", 18);
            ((Testinterface2) ic).Bike(80, "unicorn", 45);
         
        }
    }
}