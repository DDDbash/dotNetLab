using System;

namespace Simple_Interest
{
    class Program
    {
        static void Main(string[] args)
        {
            //a) Simple Interest
            Console.Write("Simple Interest:\nPrincipal: ");
            float principal = float.Parse(Console.ReadLine());
            Console.Write("Rate: ");
            float rate = float.Parse(Console.ReadLine());
            Console.Write("Time in years: ");
            float time = float.Parse(Console.ReadLine());

            float simpleInterest = (principal * time * rate) / 100;
            Console.WriteLine($"Simple Interest = {simpleInterest}");
        }
    }
}
