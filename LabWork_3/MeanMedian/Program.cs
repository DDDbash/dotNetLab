using System;

namespace MeanMedian
{
    class Program
    {
        static void Main()
        {
            int[] list = { 3, 4, 1, 7, 5, 9 };
            Array.Sort(list);
            double mean = calculateMean(list);
            double median = calculateMedian(list);
            displayMeanMedian(mean, median);
        }

        private static double calculateMean(int[] list)
        {
            double sum = addingNumbersInTheList(list);
            return sum / list.Length;
        }

        private static void displayMeanMedian(double mean, double median)
        {
            Console.WriteLine($"Mean of given list = {mean}");
            Console.WriteLine($"Median of given list = {median}");
        }

        private static double calculateMedian(int[] list)
        {
            if ((list.Length % 2) == 0)
            {
                return (list[(list.Length / 2) - 1] + list[(list.Length / 2)]) / 2.0;
            }
            else
            {
                return (list[(list.Length / 2)]);
            }
        }

        private static double addingNumbersInTheList(int[] list)
        {
            double sum = 0;
            foreach (double element in list)
            {
                sum += element;
            }
            return sum;
        }
    }
}
