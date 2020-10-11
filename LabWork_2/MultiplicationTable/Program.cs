using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main()
        {
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Until what value do you want the multiplication to go: ");
            int multiplierLimit = int.Parse(Console.ReadLine());

            for (int i = 1; i <= multiplierLimit; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
    }
}
