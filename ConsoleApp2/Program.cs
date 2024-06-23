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

        Console.Write("Enter the index to update: ");
        int indexToUpdate = int.Parse(Console.ReadLine());
        Console.Write("Enter the new value: ");
        int newValue = int.Parse(Console.ReadLine());
        UpdateArray(arr, indexToUpdate, newValue);

        Console.Write("Enter the value to insert: ");
        int valueToInsert = int.Parse(Console.ReadLine());
        Console.Write("Enter the index to insert at: ");
        int indexToInsert = int.Parse(Console.ReadLine());
        InsertArray(arr, indexToInsert, valueToInsert);

        ReverseArray(arr);

        Console.WriteLine("Updated Array:");
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

    public static void UpdateArray(int[] arr, int indexToUpdate, int newValue)
    {
        if (indexToUpdate >= 0 && indexToUpdate < arr.Length)
        {
            arr[indexToUpdate] = newValue;
        }
    }

    public static void InsertArray(int[] arr, int indexToInsert, int valueToInsert)
    {
        if (indexToInsert >= 0 && indexToInsert <= arr.Length)
        {
            int[] newArr = new int[arr.Length + 1];
            Array.Copy(arr, 0, newArr, 0, indexToInsert);
            newArr[indexToInsert] = valueToInsert;
            Array.Copy(arr, indexToInsert, newArr, indexToInsert + 1, arr.Length - indexToInsert);
            arr = newArr;
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