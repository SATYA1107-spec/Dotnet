using System;
using System.Numerics;

class Trail
{
    public static void Main(string[] args)
    {
        Random rnd = new Random();
        int num = rnd.Next(1, 4);

        Console.WriteLine(num);
        bool playagain = true;
        string name;
        Console.WriteLine("Enter your choice \n 1.rock \n 2.paper \n 3.scessors");
        int player1 = int.Parsse



        while (playagain)
        {
            switch (num)
            {
                case 1:
                    name = "ROCK";
                    Console.WriteLine(name);
                    break;

                case 2:
                    name = "PAPER";
                    Console.WriteLine(name);
                    break;

                case 3:
                    name = "SCESSORS";
                    Console.WriteLine(name);
                    break;

                default:
                    Console.WriteLine("invalid");
                    break;
            }
            while ("ROCK" == player1)
            {
                Console.WriteLine();
            }
            playagain = false;
        }
    }
}
