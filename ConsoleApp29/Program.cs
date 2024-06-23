using System;
using System.Collections.Generic;
using System.Linq;

public class JobSequencing
{
    public static void Main(string[] args)
    {
        // Input: Jobs with start time, finish time, and profit
        List<Job> jobs = new List<Job> {
            new Job('a', 1, 4, 20),
            new Job('b', 3, 5, 15),
            new Job('c', 0, 2, 10),
            new Job('d', 2, 6, 18),
            new Job('e', 6, 10, 12),
            new Job('f', 5, 7, 14),
            new Job('g', 8, 12, 16),
            new Job('h', 9, 11, 15),
        };

        // Sort jobs by finish time
        jobs.Sort((j1, j2) => j1.FinishTime - j2.FinishTime);

        // Initialize variables
        int n = jobs.Count;
        int[] dp = new int[n + 1];
        int[] chosenJobs = new int[n + 1];

        // Calculate the maximum profit
        for (int i = 1; i <= n; i++)
        {
            dp[i] = Math.Max(dp[i - 1], jobs[i - 1].Profit + dp[GetPreviousCompatibleJob(jobs, i - 1)]);
            if (dp[i] > dp[i - 1])
            {
                chosenJobs[i] = i;
            }
            else
            {
                chosenJobs[i] = chosenJobs[i - 1];
            }
        }

        // Construct the sequence of jobs
        List<char> sequence = new List<char>();
        int jobIndex = chosenJobs[n];
        while (jobIndex != 0)
        {
            sequence.Add(jobs[jobIndex - 1].Id);
            jobIndex = chosenJobs[jobIndex - 1];
        }

        // Output results
        Console.WriteLine("The Max Job sequence is:");
        sequence.Reverse();
        Console.WriteLine(string.Join(" ", sequence));
        Console.WriteLine("Total Profit: {0}", dp[n]);

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    // Helper function to find the previous compatible job
    private static int GetPreviousCompatibleJob(List<Job> jobs, int i)
    {
        for (int j = i - 1; j >= 0; j--)
        {
            if (jobs[j].FinishTime <= jobs[i].StartTime)
            {
                return j + 1;
            }
        }
        return 0;
    }
}

// Job class with ID, start time, finish time, and profit
public class Job
{
    public char Id { get; set; }
    public int StartTime { get; set; }
    public int FinishTime { get; set; }
    public int Profit { get; set; }

    public Job(char id, int startTime, int finishTime, int profit)
    {
        Id = id;
        StartTime = startTime;
        FinishTime = finishTime;
        Profit = profit;
    }
}