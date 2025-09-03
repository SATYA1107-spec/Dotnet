using System;

class Auto_meter
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Number of Kilometes Travelled");
        int km = int.Parse(Console.ReadLine());

        if (km >= 0 && km >= 10)
        {
            if (km >= 10 && km >= 20)
            {
                if (km >= 20 && km >= 30)
                {
                    if (km >= 30 && km >= 50)
                    {
                        if (km >= 50 && km >= 80)
                        {
                            if (km >= 100)
                            {
                                Console.WriteLine("Over 100 km the price should be :1500 ");
                            }

                        }
                        else
                        {
                            float charge = 10.5f;
                            var fixed_charge = 100;
                            Console.WriteLine("Your Travelling cost is " + (km * charge + fixed_charge));

                        }

                    }
                    else
                    {
                        float charge = 7.9f;
                        var fixed_charge = 60;
                        Console.WriteLine("Your Travelling cost is " + (km * charge + fixed_charge));

                    }

                }
                else
                {
                    float charge = 4.8f;
                    var fixed_charge = 40;
                    Console.WriteLine("Your Travelling cost is " + (km * charge + fixed_charge));

                }

            }
            else
            {
                float charge = 3.2f;
                var fixed_charge = 30;
                Console.WriteLine("Your Travelling cost is " + (km * charge + fixed_charge));

            }

        }
        else
        {
            int charge = 2;
            var fixed_charge = 15;
            Console.WriteLine("Your Travelling cost is " + (km * charge + fixed_charge));
        }
    }
}