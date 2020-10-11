using System;

namespace MeanMedian
{
    class Program
    {
        static void Main()
        {
            int[] list = { 3, 4, 1, 7, 5, 9 };
            Array.Sort(list);
            double sum = 0;
            foreach (double element in list)
            {
                sum += element;
            }
            double mean = sum / list.Length;
            double median = 0;
            if ((list.Length % 2) == 0)
            {
                median = (list[(list.Length / 2) - 1] + list[(list.Length / 2)]) / 2.0;
            }
            else
            {
                median = (list[(list.Length / 2)]);
            }
            Console.WriteLine($"Mean of given list = {mean}");
            Console.WriteLine($"Median of given list = {median}");
        }
    }
}
