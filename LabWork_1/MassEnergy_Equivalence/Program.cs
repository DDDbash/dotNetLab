using System;

namespace MassEnergy_Equivalence
{
    class Program
    {
        static void Main()
        {
            Console.Write("Mass of the body: ");
            int mass = int.Parse(Console.ReadLine());
            const double lightSpeed = 3e8;

            double e = mass * Math.Pow(lightSpeed, 2.0);
            Console.WriteLine($"Mass Energy Equivalence = {e}");
        }
    }
}
