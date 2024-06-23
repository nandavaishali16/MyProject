using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 15, 50, 45, 40, 90, 20, 80, 50 };

        Console.Write("array: ");
        PrintArray(arr);

        SelectionSort(arr);

        Console.WriteLine("sorted by selection sort:");
        PrintArray(arr);

        Console.Write("Target Element :");
        int target = int.Parse(Console.ReadLine());

        int index = FindElement(arr, target);
        if (index != -1)
            Console.WriteLine($"Element is found at index: {index}");
        else
            Console.WriteLine("Element not found.");

        Console.ReadLine();
    }

    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }

    static int FindElement(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i;
        }
        return -1;
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}