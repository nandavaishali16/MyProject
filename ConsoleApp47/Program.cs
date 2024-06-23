using System;

class Program
{
    static void Main(string[] args)
    {
        // Simulate a transaction
        bool transactionSuccess = PerformTransaction();

        if (transactionSuccess)
        {
            Console.WriteLine("Transaction committed successfully.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(); // Wait for user to press a key
        }
        else
        {
            Console.WriteLine("Transaction failed.");
        }
    }

    // Helper method to simulate a transaction
    static bool PerformTransaction()
    {
        // Perform transaction logic here
        // For this example, let's assume the transaction is always successful
        return true;
    }
}