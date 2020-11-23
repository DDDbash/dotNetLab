using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            FizzBuzz();
        }

        private static void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                CheckFizzBuzz(i);
            }
        }

        private static void CheckFizzBuzz(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else
                Console.WriteLine(i);
        }
    }
}
