using System;

class Mul
{
    public static void Main(string[] args)
    {
        int[,] a = new int[20,20];
        int[,] b = new int[20,20];
        int[,] mul = new int[20,20];

        Console.Write("Enter Required number of rows in Matrix A : ");
        int r1 = int.Parse(Console.ReadLine());
        Console.Write("Enter Required number of Collumns in Matrix A : ");
        int c1 = int.Parse(Console.ReadLine());
        Console.Write("Enter Required number of rows in Matrix B : ");
        int r2 = int.Parse(Console.ReadLine());
        Console.Write("Enter Required number of Columns in Matrix B : ");
        int c2 = int.Parse(Console.ReadLine());

        if (c1 == r2)
        {
            for (int i = 0; i < r1; i++)
            {
                for(int j = 0; j < c1; j++)
                {
                   
                    Console.Write($"Enter values of matrix A [{i},{j}] : ");
                    a[i,j] =int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < r2; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    Console.Write($"Enter values of matrix B [{i},{j}] : ");
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Matrix A");
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c1; j++)
                {
                    Console.Write(a[i,j]+"\t");
                }

                Console.WriteLine();
            }
            Console.WriteLine("Matrix B");
            for (int i = 0; i < r2; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    Console.Write(b[i, j]+"\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    mul[i, j] = 0;
                    for (int k = 0; k < c1; k++)
                    {
                        mul[i,j] = mul[i,j] + a[i, k] * b[k,j];
                    }
                }
            }
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    Console.Write(mul[i,j]);
                }
                Console.WriteLine();
            }

        }
        else
        {
            Console.WriteLine($"For matrix Multiplicaton {c1} must be Equal to {r2}");
        }
    }
}   