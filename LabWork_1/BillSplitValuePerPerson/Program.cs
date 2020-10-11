using System;

namespace BillSplitValuePerPerson
{
    class Program
    {
        static void Main()
        {
            Console.Write("Total Cost: ");
            float cost = int.Parse(Console.ReadLine());
            Console.Write("Number of person: ");
            int numberPerson = int.Parse(Console.ReadLine());

            double costPerPerson = cost / numberPerson;
            Console.WriteLine($"Cost per person = {costPerPerson}");
        }
    }
}
