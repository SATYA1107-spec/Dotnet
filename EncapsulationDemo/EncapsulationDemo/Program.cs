using System;

namespace EncapsulationDemo
{
    class Car
    {
        private int Speed;

        public int  speed
        {
            get
            {
                return Speed; 
            } 
            set
            {
               if (value > 500)
                {
                    Speed = 100;
                    throw new Exception("maximum speed reached , so speed limited to " + speed);
                }
               else
                {
                    Speed = value;
                }
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Car car = new Car();
                car.speed = 300;
                Console.WriteLine(car.speed);
                car.speed = 600;
                Console.WriteLine(car.speed);
                car.speed = 200;
                Console.WriteLine(car.speed);
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
