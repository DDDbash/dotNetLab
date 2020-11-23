using System;

namespace SumDifferenceMatrices
{
    class Program
    {
        static void Main()
        {
            int row = getRow();
            int column = getColumn();

            int[,] matrix1 = enterDataInMatrix(row, column);

            int[,] matrix2 = enterDataInMatrix(row, column);

            int[,] sum = matricesSum(row, column, matrix1, matrix2);
            int[,] difference = matricesDifference(row, column, matrix1, matrix2);

            DisplaySumDifference(row, column, sum, difference);
        }

        private static void DisplaySumDifference(int row, int column, int[,] sum, int[,] difference)
        {
            DisplayDifference(row, column, difference);
            DisplaySum(row, column, sum);
        }

        private static void DisplayDifference(int row, int column, int[,] difference)
        {
            Console.WriteLine("Difference:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{difference[i, j]}\t");
                }
                Console.WriteLine("");
            }
        }

        private static void DisplaySum(int row, int column, int[,] sum)
        {
            Console.WriteLine("Sum:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{sum[i, j]}\t");
                }
                Console.WriteLine("");

            }
        }

        private static int[,] matricesSum(int row, int column, int[,] matrix1, int[,] matrix2)
        {
            int[,] sum = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    sum[i, j] = matrix1[i, j] + matrix2[i, j];
                }

            }
            return sum;
        }

        private static int[,] matricesDifference(int row, int column, int[,] matrix1, int[,] matrix2)
        {
            int[,] difference = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    difference[i, j] = matrix1[i, j] - matrix2[i, j];
                }

            }
            return difference;
        }

        private static int[,] enterDataInMatrix(int row, int column)
        {
            Console.WriteLine("Enter matrix data: ");
            int[,] matrix = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }

            }

            return matrix;
        }

        private static int getColumn()
        {
            Console.Write("Enter matrix column: ");
            return int.Parse(Console.ReadLine());
        }

        private static int getRow()
        {
            Console.Write("Enter matrix row: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
