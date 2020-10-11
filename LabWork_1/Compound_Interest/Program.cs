using System;

namespace Compound_Interest
{
    class Program
    {
        static void Main()
        {
            //b) Compound Interest
            Console.Write("Principal: ");
            int principal = int.Parse(Console.ReadLine());
            Console.Write("Rate: ");
            double rate = double.Parse(Console.ReadLine());
            Console.Write("Number of times interest is compounded per year: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Time in years: ");
            int time = int.Parse(Console.ReadLine());

            double temp = 1 + (rate / n);
            double compoundInterest = (principal * (Math.Pow(temp, (n * time)))) - principal;
            Console.Write($"Compound Interest is = {compoundInterest}");
        }
    }
}
