using System;

namespace DiceRollingSimulator
{
    public class DiceSimulation
    {
        // Method to simulate dice rolls and return the array of results
        public int[] RollDices(int numberOfRolls)
        {
            int[] results = new int[13]; // Index 0 and 1 are not used for simplicity
            Random rand = new Random();

            for (int i = 0; i < numberOfRolls; i++)
            {
                int roll = rand.Next(1, 7) + rand.Next(1, 7); // Rolling two 6-sided dice
                results[roll]++;
            }

            return results;
        }
    }
}
