using System;

class AddMat
{
    public static void Main(string[] args)
    {
        int[,] a = new int[20, 20];
        int[,] b = new int[20, 20];
        int[,] sum = new int[20, 20];

        Console.WriteLine("Enter matrix size of A matrix");
        int k = int.Parse(Console.ReadLine());
        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < k; j++)
            {
                Console.Write($"Enter element [{i},{j}]: ");
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Enter matrix size of B matrix");
        int e = int.Parse(Console.ReadLine());
        for (int i = 0; i < e; i++)
        {
            for (int j = 0; j < e; j++)
            {
                Console.Write($"Enter element [{i},{j}]: ");
                b[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Display of matrix A");
        Console.WriteLine();
        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < k; j++)
            {
                Console.Write(a[i,j]+"\t");
           
            }
            Console.WriteLine();
        }
        Console.WriteLine("Display of matrix B");
        Console.WriteLine();
        for (int i = 0; i < e; i++)
        {
            for (int j = 0; j < e; j++)
            {
                Console.Write(b[i, j]+"\t");

            }
            Console.WriteLine();
        }
        Console.WriteLine("Addition of Matrix A & B");
        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < k; j++)
            {
                sum[i, j] = a[i, j] + b[i, j];
                Console.Write(sum[i,j]+"\t");

            }
            Console.WriteLine();
      
        }
       

    }
    
}