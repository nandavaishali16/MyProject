using System;

class Program
{
    static void Main(string[] args)
    {
        int[] profits = { 50, 40, 90, 10, 5, 11, 70, 15 };
        int[] weights = { 3, 4, 6, 4, 1, 2, 5, 2 };
        int capacity = 20;
        int[,] dp = new int[profits.Length + 1, capacity + 1];

        for (int i = 1; i <= profits.Length; i++)
        {
            for (int w = 1; w <= capacity; w++) // Changed variable name from 'j' to 'w'
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

        Console.WriteLine("Maximum profit: " + dp[profits.Length, capacity]);

        // Print the selected items
        int itemIndex = profits.Length;
        int remainingCapacity = capacity;

        while (itemIndex > 0 && remainingCapacity > 0)
        {
            if (dp[itemIndex, remainingCapacity] != dp[itemIndex - 1, remainingCapacity])
            {
                Console.WriteLine("Item " + (itemIndex - 1) + " is selected");
                remainingCapacity -= weights[itemIndex - 1];
            }
            itemIndex--;
            Console.ReadLine();
        }
    }
}