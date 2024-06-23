using System;

public class BubbleSort
{
    public static void Main(string[] args)
    {
        // Unsorted array
        int[] array = { 85, 50, 90, 10, 30, 45, 20, 90 };

        Console.WriteLine("Array in beginning");
        PrintArray(array);

        // Sort the array using bubble sort
        BubbleSortArray(array);

        Console.WriteLine("Array after Bubble sort");
        PrintArray(array);

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    // Function to sort the array using bubble sort
    public static void BubbleSortArray(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Swap array[j] and array[j + 1]
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    // Function to print the array
    public static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}