using System;

namespace GuessingGame
{
    class Program
    {
        static void Main()
        {
            string choice;
            do
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 101);

                bool didWin = false;

                for (int i = 1; i <= 5; i++)
                {
                    Console.Write("Guess: ");
                    int guess = int.Parse(Console.ReadLine());
                    if (guess == randomNumber)
                    {
                        Console.WriteLine("Hooray! You won.");
                        didWin = true;
                        break;
                    }
                    else if (guess > randomNumber)
                    {
                        Console.WriteLine("Your guess is greater than my number.");
                    }
                    else
                    {
                        Console.WriteLine("Your guess is less than my number.");
                    }
                }
                if (!didWin)
                {
                    Console.WriteLine("Oh no! You lost.");
                    Console.WriteLine($"Correct number is: {randomNumber}");
                }
                Console.WriteLine("Replay (Y/N)?");
                choice = Console.ReadLine().ToUpper();
            } while (choice == "Y");
        }
    }
}
