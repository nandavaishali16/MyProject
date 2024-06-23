using System;

class KnapsackProblem
{
    static void Main(string[] args)
    {
        // Define the items with their weights and profits
        int[] weights = { 3, 4, 6, 5, 2 }; // weights of items
        int[] profits = { 50, 40, 90, 70, 15 }; // profits of items
        int capacity = 15; // maximum weight capacity of the knapsack
        int n = weights.Length; // number of items

        // Create a 2D array to store the dynamic programming table
        int[,] dp = new int[n + 1, capacity + 1];

        // Initialize the first row and column of the table
        for (int i = 0; i <= n; i++)
        {
            for (int w = 0; w <= capacity; w++)
            {
                if (i == 0 || w == 0)
                    dp[i, w] = 0;
                else if (weights[i - 1] <= w)
                    dp[i, w] = Math.Max(profits[i - 1] + dp[i - 1, w - weights[i - 1]], dp[i - 1, w]);
                else
                    dp[i, w] = dp[i - 1, w];
            }
        }

        // Print the maximum profit
        Console.WriteLine("Total Profit: " + dp[n, capacity]);

        // Print the selected items
        int remainingCapacity = capacity;
        for (int i = n; i > 0; i--)
        {
            if (dp[i, remainingCapacity] != dp[i - 1, remainingCapacity])
            {
                Console.WriteLine("Object " + (char)('A' + i - 1) + ": (Weight " + weights[i - 1] + ", Profit " + profits[i - 1] + ")");
                remainingCapacity -= weights[i - 1];
            }
        }

        // Print the remaining capacity
        Console.WriteLine("Remaining Capacity: " + remainingCapacity);
        Console.ReadLine();
    }
}