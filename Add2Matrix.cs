using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] matrix1 = new int[rows, cols];
        int[,] matrix2 = new int[rows, cols];
        int[,] result = new int[rows, cols];

        Console.WriteLine("Enter elements for first matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Matrix1[{i},{j}]: ");
                matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter elements for second matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Matrix2[{i},{j}]: ");
                matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Adding matrices
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        Console.WriteLine("Resultant Matrix after Addition:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(result[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
