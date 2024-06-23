using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the Number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            int setBitCount = CountSetBits(i);
            Console.WriteLine($"{i}: Number of set bit count : {setBitCount}");
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    public static int CountSetBits(int n)
    {
        int count = 0;
        while (n != 0)
        {
            count += n & 1;
            n >>= 1;
        }
        return count;
    }
}