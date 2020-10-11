using System;

namespace Volume_Sphere
{
    class Program
    {
        static void Main()
        {
            Console.Write("Radius: ");
            int radius = int.Parse(Console.ReadLine());

            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3.0);
            Console.WriteLine($"Volume of the sphere = {volume}");
        }
    }
}
