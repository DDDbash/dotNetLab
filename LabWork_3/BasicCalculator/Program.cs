using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main()
        {
            while (true)
                Calculator();
        }


        private static void Calculator()
        {
            Console.Write("What action do you want to perform?\n1)Addition\n2)Subtraction\n3)Multiplication\n4)Division\n5)Exit\nYour Choice: ");
            Calculations();
        }

        private static void Calculations()
        {
            int firstNumber, secondNumber;
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Input(out firstNumber, out secondNumber);
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                    break;

                case 2:
                    Input(out firstNumber, out secondNumber);
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                    break;

                case 3:
                    Input(out firstNumber, out secondNumber);
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                    break;

                case 4:
                    Input(out firstNumber, out secondNumber);
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {(double)firstNumber / secondNumber}");
                    break;

                case 5:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }

        private static void Input(out int firstNumber, out int secondNumber)
        {
            Console.WriteLine("Enter first number: ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            secondNumber = int.Parse(Console.ReadLine());
        }
    }
}
