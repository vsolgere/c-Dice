using System;

namespace DiceRollingSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
            int numberOfRolls = int.Parse(Console.ReadLine());

            DiceSimulation diceSimulator = new DiceSimulation();
            int[] results = diceSimulator.RollDices(numberOfRolls);

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {numberOfRolls}.");

            for (int i = 2; i <= 12; i++)
            {
                Console.Write($"{i}: ");
                int stars = (int)((double)results[i] / numberOfRolls * 100);
                Console.WriteLine(new String('*', stars));
            }

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}