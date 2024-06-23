using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Define the tables in the database
        List<string> tables = new List<string>() { "Table1", "Table2" };

        // Display the tables
        Console.WriteLine("Tables in the database:");
        foreach (string table in tables)
        {
            Console.WriteLine(table);
        }

        // Wait for user input
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}