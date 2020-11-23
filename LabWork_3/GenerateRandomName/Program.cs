using System;

namespace GenerateRandomName
{
    class Program
    {
        static void Main()
        {
            string[] namesForBaby = { "Kevin", "John", "Harry", "Olivier" };
            int randomNameIndex = randomName(namesForBaby);
            Console.WriteLine($"Randomly Selected Name for baby is {namesForBaby[randomNameIndex]}");
        }

        private static int randomName(string[] namesForBaby)
        {
            Random rand = new Random();
            return rand.Next(namesForBaby.Length);
        }
    }
}
