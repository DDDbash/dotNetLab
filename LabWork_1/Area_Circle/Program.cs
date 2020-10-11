using System;

namespace Area_Circle
{
    class Program
    {
        static void Main()
        {
            // Area of a Circle
            Console.Write("Radius of Circle: ");
            int radius = int.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Area of the circle = {area}");
        }
    }
}
