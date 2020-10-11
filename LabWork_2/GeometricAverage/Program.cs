using System;

namespace GeometricAverage
{
    class Program
    {
        static void Main()
        {
            Console.Write("Total numbers in the list: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbers in the list: ");
            int[] list = new int[100];
            double multiply = 1;
            for (int i = 0; i < n; i++)
            {
                list[i] = int.Parse(Console.ReadLine());
                multiply *= list[i];
            }
            double geometricMean = Math.Pow(multiply, 1.0 / n);
            Console.Write($"Geometric mean = {geometricMean}");
        }
    }
}
