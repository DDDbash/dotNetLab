using System;

namespace BMI
{
    class Program
    {
        static void Main()
        {
            Console.Write("Weight in kgs: ");
            float weight = float.Parse(Console.ReadLine());
            Console.Write("Height in metres: ");
            float height = float.Parse(Console.ReadLine());

            double bmi = weight / Math.Pow(height, 2.0);
            Console.WriteLine($"Body Mass Index = {bmi}");
        }
    }
}
