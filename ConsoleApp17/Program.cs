using System;

class Program
{
    static void Main()
    {
        int n = 10;
        int setBitCount = CountSetBits(n);
        Console.WriteLine($"The total number of set bits in all integers from 1 to {n} is: {setBitCount}");
    }

    public static int CountSetBits(int n)
    {
        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            int num = i;
            while (num != 0)
            {
                count += num & 1;
                num >>= 1;
            }
        }
        return count;'
    }
    Console.Read();
}