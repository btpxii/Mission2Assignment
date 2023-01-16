using System;

namespace Mission2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] rollCounts = new int[11];
            int numRolls;
            Console.WriteLine("Welcome to the dice throwing simulator!\nHow many times would you like to roll the dice? ");
            numRolls = int.Parse(Console.ReadLine());

            for (int i = 0; i < numRolls; i++)
            {
                int roll1 = rand.Next(1,7);
                int roll2 = rand.Next(1,7);
                int totalRoll = roll1 + roll2;
                rollCounts[totalRoll - 2]++;
            }
            Console.WriteLine("\nSIMULATION RESULTS\nEach asterisk represents 1% of the total number of rolls\n");
            for (int i = 2; i <= 12; i++)
            {
                string output = "";
                double pct = ((double)rollCounts[i-2] / numRolls)*100;
                output = output + i.ToString() + ": \t";
                for (int j = 0; j < pct; j++)
                {
                    output = output + "*";
                }
                Console.WriteLine(output);
            }
            Console.WriteLine("\nThanks for using the dice throwing simulator. Goodbye!");
        }
    }
}
