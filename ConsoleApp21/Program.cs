using System;

class Program
{
    static void Main(string[] args)
    {
        int a, b;

        Console.WriteLine("1 Enter 1st number");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("3 Enter 2nd number");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("5 Before Swapping a : {0}, b : {1}", a, b);

        SwapNumbers(ref a, ref b);

        Console.WriteLine("6 After swapping a : {0}, b : {1}", a, b);
    }

    static void SwapNumbers(ref int a, ref int b)
    {
        a = a ^ b;
        b = a ^ b;
        a = a ^ b;
    }
}