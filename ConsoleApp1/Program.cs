using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the elements of the array: ");
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(input, int.Parse);

        Console.WriteLine("Original Array:");
        PrintArray(arr);

        ReverseArray(arr);

        Console.WriteLine("Reversed Array:");
        PrintArray(arr);

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    public static void ReverseArray(int[] arr)
    {
        int start = 0;
        int end = arr.Length - 1;

        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }

    public static void PrintArray(int[] arr)
    {
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}