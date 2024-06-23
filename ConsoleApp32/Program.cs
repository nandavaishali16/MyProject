using System;

namespace KnapsackProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] profits = { 50, 40, 90, 10, 5, 11, 70, 15 };
            int[] weights = { 3, 4, 6, 4, 1, 2, 5, 2 };
            int weightCapacity = 20;

            int[,] dp = new int[profits.Length + 1, weightCapacity + 1];

            for (int i = 1; i <= profits.Length; i++)
            {
                for (int w = 1; w <= weightCapacity; w++)
                {
                    if (weights[i - 1] <= w)
                    {
                        dp[i, w] = Math.Max(profits[i - 1] + dp[i - 1, w - weights[i - 1]], dp[i - 1, w]);
                    }
                    else
                    {
                        dp[i, w] = dp[i - 1, w];
                    }
                }
            }

            Console.WriteLine("Maximum profit: " + dp[profits.Length, weightCapacity]);

            // Print the selected items
            int remainingWeight = weightCapacity;
            for (int i = profits.Length; i > 0; i--)
            {
                if (dp[i, remainingWeight] != dp[i - 1, remainingWeight])
                {
                    Console.WriteLine("Item " + (i - 1) + " selected");
                    remainingWeight -= weights[i - 1];
                }
                Console.ReadLine();
            }
        }
    }
}