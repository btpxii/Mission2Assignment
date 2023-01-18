using System;

namespace Mission2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the random class
            Random rand = new Random();
            // Create an array to store the count of rolls for each possible total, from 2 through 12
            int[] rollCounts = new int[11];
            // Variable that will store the number of rolls, given by the user
            int numRolls;
            // Welcome message and prompt for the user to enter how many dice rolls they would like the program to perform
            Console.WriteLine("Welcome to the dice throwing simulator!\nHow many times would you like to roll the dice? ");
            numRolls = int.Parse(Console.ReadLine());
            // Loop that simulates the number of dice rolls, established above
            for (int i = 0; i < numRolls; i++)
            {
                // Simulates an individual rolling of each dice
                int roll1 = rand.Next(1,7);
                int roll2 = rand.Next(1,7);
                // Adds the totals of each roll together
                int totalRoll = roll1 + roll2;
                // Increments the counter for the roll outcome
                rollCounts[totalRoll - 2]++;
            }
            // Output the simulation results
            Console.WriteLine("\nSIMULATION RESULTS\nEach asterisk represents 1% of the total number of rolls\n");
            // Loop that checks each possible roll total
            for (int i = 2; i <= 12; i++)
            {
                string output = "";
                // Calculates the percentage of rolls that resulted in each outcome, out of the total number of rolls performed
                double pct = ((double)rollCounts[i-2] / numRolls)*100;
                // Adds the roll outcome label to the output string
                output = output + i.ToString() + ": \t";
                // Loop that adds the count of asterisks (as a percent) to the output string for each roll outcome
                for (int j = 0; j < pct; j++)
                {
                    output = output + "*";
                }
                // Writes the simulation results to the console
                Console.WriteLine(output);
            }
            Console.WriteLine("\nThanks for using the dice throwing simulator. Goodbye!");
        }
    }
}
