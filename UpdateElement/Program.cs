using System;

namespace UpdateElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int elementToUpdate = 9;
            int index = 2;

            UpdateElement(arr, elementToUpdate, index);

            Console.WriteLine("Updated array:");
            PrintArray(arr);
        }

        static void UpdateElement(int[] arr, int elementToUpdate, int index)
        {
            if (index < 0 || index >= arr.Length)
            {
                throw new ArgumentOutOfRangeException("Index out of range.");
            }

            arr[index] = elementToUpdate;
        }

        static void PrintArray(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
            Console.ReadLine();

        }
    }
}