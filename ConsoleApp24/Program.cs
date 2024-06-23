using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string[] filePaths = { @"C:\\Wipro Training\\Wipro Assignment\\Practice" };

        var tasks = new Task[filePaths.Length];
        for (int i = 0; i < filePaths.Length; i++)
        {
            tasks[i] = ReadFileAsync(filePaths[i]);
        }

        await Task.WhenAll(tasks);

        Console.WriteLine("Finished reading data from files in parallel.");
    }

    static async Task ReadFileAsync(string filePath)
    {
        string[] lines = await File.ReadAllLinesAsync(filePath);
        Console.WriteLine($"Read {lines.Length} lines from {filePath}.");
    }
}