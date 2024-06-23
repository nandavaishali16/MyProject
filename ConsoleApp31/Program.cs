using System;
using System.Collections.Generic;

public class Job
{
    public int Profit { get; set; }
    public int Deadline { get; set; }
    public char Id { get; set; }

    public Job(char id, int profit, int deadline)
    {
        Id = id;
        Profit = profit;
        Deadline = deadline;
    }
}

public class JobSequencing
{
    public static void Main()
    {
        List<Job> jobs = new List<Job>
        {
            new Job('a', 50, 2),
            new Job('b', 40, 2),
            new Job('c', 90, 1),
            new Job('d', 10, 3),
            new Job('e', 5, 3),
            new Job('f', 11, 2),
            new Job('g', 70, 1),
            new Job('h', 15, 4)
        };

        int maxDeadline = 4;
        char[] jobSequence = new char[maxDeadline];
        bool[] timeSlot = new bool[maxDeadline];

        for (int i = 0; i < timeSlot.Length; i++)
        {
            timeSlot[i] = false;
        }

        // Sort jobs in descending order of profit
        jobs.Sort((a, b) => b.Profit.CompareTo(a.Profit));

        int totalProfit = 0;

        foreach (var job in jobs)
        {
            for (int j = Math.Min(maxDeadline, job.Deadline) - 1; j >= 0; j--)
            {
                if (!timeSlot[j])
                {
                    jobSequence[j] = job.Id;
                    timeSlot[j] = true;
                    totalProfit += job.Profit;
                    break;
                }
            }
        }

        Console.WriteLine("Job sequence for maximum profit:");
        foreach (var job in jobSequence)
        {
            if (job != '\0')
                Console.Write(job + " ");
        }

        Console.WriteLine($"\nTotal profit: {totalProfit}");
        Console.ReadLine();
    }
}