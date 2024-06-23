using System;

class KnapsackProblem
{
    static void Main()
    {
        int[] profits = { 50, 90, 70, 40, 15 };
        int[] weights = { 3, 6, 5, 4, 2 };
        int capacity = 10;
        int n = profits.Length;

        int maxProfit = Knapsack(profits, weights, capacity, n);
        Console.WriteLine("Maximum Profit: " + maxProfit);
    }

    static int Knapsack(int[] profits, int[] weights, int capacity, int n)
    {
        int[,] dp = new int[n + 1, capacity + 1];

        for (int i = 0; i <= n; i++)
        {
            for (int w = 0; w <= capacity; w++)
            {
                if (i == 0 || w == 0)
                {
                    dp[i, w] = 0;
                }
                else if (weights[i - 1] <= w)
                {
                    dp[i, w] = Math.Max(profits[i - 1] + dp[i - 1, w - weights[i - 1]], dp[i - 1, w]);
                }
                else
                {
                    dp[i, w] = dp[i - 1, w];
                }

                // Print the current state of the dp array for debugging
                Console.WriteLine($"dp[{i},{w}] = {dp[i, w]}");
            }
        }

        // Print the final dp array for debugging
        Console.WriteLine("Final DP Table:");
        for (int i = 0; i <= n; i++)
        {
            for (int w = 0; w <= capacity; w++)
            {
                Console.Write(dp[i, w] + "\t");
            }
            Console.WriteLine();
        }

        return dp[n, capacity];
        Console.ReadLine();
    }
}
