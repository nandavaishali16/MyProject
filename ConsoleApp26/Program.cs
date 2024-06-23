using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(string[] args)
    {
        // Enter the array elements
        Console.WriteLine("Enter the array elements:");
        string inputString = Console.ReadLine();
        string[] inputArray = inputString.Split(',');
        int[] array = new int[inputArray.Length];
        for (int i = 0; i < inputArray.Length; i++)
        {
            string numericString = Regex.Replace(inputArray[i], @"[^\d]", "");
            array[i] = int.Parse(numericString);
        }

        // Enter the search element
        Console.WriteLine("Enter the search element:");
        int searchElement = int.Parse(Console.ReadLine());

        // Search for the element in the array
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == searchElement)
            {
                index = i;
                break;
            }
        }

        // Print the result
        if (index == -1)
        {
            Console.WriteLine("Element not found.");
        }
        else
        {
            Console.WriteLine($"Element found at index: {index}");
        }
    }
}