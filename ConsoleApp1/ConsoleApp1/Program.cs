using System;

class Add
{
    public static void Main(string[] args)
    {
        int[,] a = new int[10, 10];
        int[,] b = new int[10, 10];
        int[,] Mul = new int[10, 10];

        Console.Write("Enter No of Rows Required for matrix A : ");
        int r1 = int.Parse(Console.ReadLine());
        Console.Write("Enter No of Columns Required for matrix A : ");
        int c1 = int.Parse(Console.ReadLine());
        Console.Write("Enter No of Rows Required for matrix B : ");
        int r2 = int.Parse(Console.ReadLine());
        Console.Write("Enter No of Columns Required for matrix B : ");
        int c2 = int.Parse(Console.ReadLine());

        for (int i = 0; i < r1; i++)
        {
            for (int j = 0; j < c1; j++)
            {
                Console.Write($"Enter elemant of A matrix [{i},{j}] :");
                a[i,j]= int.Parse(Console.ReadLine());
            }

        }
        Console.WriteLine();
        for (int i = 0; i < r2; i++)
        {
            for (int j = 0; j < c2; j++)
            {
                Console.Write($"Enter elemant of B matrix [{i},{j}] :");
                b[i, j] = int.Parse(Console.ReadLine());
            }

        }
        Console.WriteLine("Display of marix A");
        for (int i = 0; i < r1; i++)
        {
            for (int j = 0; j < c1; j++)
            {
                Console.Write(a[i,j]+"\t");
            }
            Console.WriteLine();

        }
        Console.WriteLine("Display of matrix B");
        for (int i = 0; i < r2; i++)
        {
            for (int j = 0; j < c2; j++)
            {
                Console.Write(b[i,j]+"\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("A of Two Matrices");
        if (r1 == c2)
        {

            for (int i = 0; i < r2; i++)
            {
                for (int j = 0; j < c1; j++)
                {
                    Mul[i, j] = 0;
                    for (int k = 0; k < r1; k++)
                    {
                        Mul[i, j] = Mul[i, j] + a[i, k] * b[k, j];
                    } 
                }
            }
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    Console.Write(Mul[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("not possible");
        }


    }
}