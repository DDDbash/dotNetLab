using System;

namespace SumDifferenceMatrices
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter matrix row: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter matrix column: ");
            int column = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 1st matrix data: ");
            int[,] matrix1 = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }

            }

            Console.WriteLine("Enter 2nd matrix data: ");
            int[,] matrix2 = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }

            }

            int[,] sum = new int[row, column];
            int[,] difference = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    sum[i, j] = matrix1[i, j] + matrix2[i, j];
                    difference[i, j] = matrix1[i, j] - matrix2[i, j];
                }

            }

            Console.WriteLine("Sum of the matrices: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{sum[i, j]}\t");
                }
                Console.WriteLine("");

            }
            Console.WriteLine("Difference of the matrices: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{difference[i, j]}\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
