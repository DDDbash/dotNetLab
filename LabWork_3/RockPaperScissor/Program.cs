using System;

namespace RockPaperScissor
{
    class Program
    {
        static void Main()
        {
            do
            {
                StartNewGame();
            } while (UserWantsToReplay());
        }

        private static bool UserWantsToReplay()
        {
            Console.Write("Reply(Y/N): ");
            return Console.ReadLine().ToUpper() == "Y";
        }

        private static void StartNewGame()
        {
            string choice = Input();
            GenerateComputersChoice(choice);
        }

        private static void GameProcess(string choice, string[] options, int randomComputersChoiceIndex)
        {
            switch (choice.ToUpper())
            {
                case "ROCK":
                    IfUserSelectsRock(options, randomComputersChoiceIndex);
                    break;

                case "PAPER":
                    IfUserSelectsPaper(options, randomComputersChoiceIndex);
                    break;

                case "SCISSOR":
                    IfUserSelectsScissor(options, randomComputersChoiceIndex);
                    break;

                default:
                    Console.WriteLine("Your choice isn't valid.");
                    break;
            }
        }

        private static void IfUserSelectsScissor(string[] options, int randomComputersChoiceIndex)
        {
            if (options[randomComputersChoiceIndex] == "Scissor")
                Console.WriteLine($"The computer chose {options[randomComputersChoiceIndex]}. It's a draw!");
            else if (options[randomComputersChoiceIndex] == "Rock")
                Console.WriteLine($"The computer chose {options[randomComputersChoiceIndex]}. You lose!");
            else if (options[randomComputersChoiceIndex] == "Paper")
                Console.WriteLine($"The computer chose {options[randomComputersChoiceIndex]}. You win!");
        }

        private static void IfUserSelectsPaper(string[] options, int randomComputersChoiceIndex)
        {
            if (options[randomComputersChoiceIndex] == "Paper")
                Console.WriteLine($"The computer chose {options[randomComputersChoiceIndex]}. It's a draw!");
            else if (options[randomComputersChoiceIndex] == "Scissor")
                Console.WriteLine($"The computer chose {options[randomComputersChoiceIndex]}. You lose!");
            else if (options[randomComputersChoiceIndex] == "Rock")
                Console.WriteLine($"The computer chose {options[randomComputersChoiceIndex]}. You win!");
        }

        private static void IfUserSelectsRock(string[] options, int randomComputersChoiceIndex)
        {
            if (options[randomComputersChoiceIndex] == "Rock")
                Console.WriteLine($"The computer chose {options[randomComputersChoiceIndex]}. It's a draw!");
            else if (options[randomComputersChoiceIndex] == "Paper")
                Console.WriteLine($"The computer chose {options[randomComputersChoiceIndex]}. You lose!");
            else if (options[randomComputersChoiceIndex] == "Scissor")
                Console.WriteLine($"The computer chose {options[randomComputersChoiceIndex]}. You win!");
        }

        private static void GenerateComputersChoice(string choice)
        {
            string[] options = { "Rock", "Paper", "Scissor" };
            int randomComputersChoiceIndex = GenerateRandomChoice(options);
            GameProcess(choice, options, randomComputersChoiceIndex);
        }

        private static int GenerateRandomChoice(string[] options)
        {
            Random rand = new Random();
            return rand.Next(options.Length);
        }

        private static string Input()
        {
            Console.Write("Select your option: ");
            return Console.ReadLine();
        }
    }
}
