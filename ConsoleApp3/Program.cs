using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the size of the array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter the element to insert: ");
        int element = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the index where to insert the element: ");
        int index = Convert.ToInt32(Console.ReadLine());

        InsertElement(arr, index, element);

        Console.WriteLine("Array after inserting element:");
        PrintArray(arr);

        Console.Write("Enter the element to update: ");
        element = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the index where to update the element: ");
        index = Convert.ToInt32(Console.ReadLine());

        UpdateElement(arr, index, element);

        Console.WriteLine("Array after updating element:");
        PrintArray(arr);

        ReverseArray(arr);

        Console.WriteLine("Array after reversing:");
        PrintArray(arr);

        Console.ReadLine();
    }

    static void InsertElement(int[] arr, int index, int element)
    {
        int[] newArr = new int[arr.Length + 1];
        Array.Copy(arr, 0, newArr, 0, index);
        newArr[index] = element;
        Array.Copy(arr, index, newArr, index + 1, arr.Length - index);
        arr = newArr;
    }

    static void UpdateElement(int[] arr, int index, int element)
    {
        if (index >= 0 && index < arr.Length)
        {
            arr[index] = element;
        }
    }

    static void ReverseArray(int[] arr)
    {
        Array.Reverse(arr);
    }

    static void PrintArray(int[] arr)
    {
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}