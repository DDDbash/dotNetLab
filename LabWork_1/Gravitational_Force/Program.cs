using System;

namespace Gravitational_Force
{
    class Program
    {
        static void Main()
        {
            Console.Write("Mass of first object: ");
            int massOne = int.Parse(Console.ReadLine());
            Console.Write("Mass of second object: ");
            int massTwo = int.Parse(Console.ReadLine());
            Console.Write("Distance between the two objects: ");
            int distance = int.Parse(Console.ReadLine());
            const double G = 6.67e-11;

            double gravitationalForce = G * massOne * massTwo / Math.Pow(distance, 2.0);
            Console.WriteLine($"Gravitational Force = {gravitationalForce}");
        }
    }
}
