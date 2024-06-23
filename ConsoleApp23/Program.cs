using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string filePath1 = "file1.txt";
        string filePath2 = "file2.txt";
        string filePath3 = "file3.txt";

        // Create tasks for writing to files asynchronously
        var task1 = WriteNumbersToFileAsync(filePath1, 1, 100);
        var task2 = WriteNumbersToFileAsync(filePath2, 1, 100);
        var task3 = WriteNumbersToFileAsync(filePath3, 1, 100);

        // Wait for all tasks to complete
        await Task.WhenAll(task1, task2, task3);

        Console.WriteLine("Data written to all files asynchronously.");

        // Write to files synchronously with a delay
        WriteNumbersToFileWithDelay(filePath1, 1, 100);
        WriteNumbersToFileWithDelay(filePath2, 1, 100);
        WriteNumbersToFileWithDelay(filePath3, 1, 100);

        Console.WriteLine("Data written to all files synchronously with delay.");
    }

    static async Task WriteNumbersToFileAsync(string filePath, int start, int end)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            for (int i = start; i <= end; i++)
            {
                await writer.WriteLineAsync(i.ToString());
            }
        }
    }

    static void WriteNumbersToFileWithDelay(string filePath, int start, int end)
    {
        using (StreamWriter writer = new StreamWriter(filePath, true)) // Append mode
        {
            for (int i = start; i <= end; i++)
            {
                writer.WriteLine(i.ToString());
                Thread.Sleep(200);
            }
        }
    }
}