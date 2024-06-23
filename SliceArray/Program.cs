using System;

namespace SliceArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int startIndex = 3;
            int endIndex = 7;

            int[] slicedArr = SliceArray(arr, startIndex, endIndex);

            Console.WriteLine("Original array:");
            PrintArray(arr);

            Console.WriteLine("\nSliced array:");
            PrintArray(slicedArr);
        }

        static int[] SliceArray(int[] arr, int startIndex, int endIndex)
        {
            if (startIndex < 0 || startIndex >= arr.Length || endIndex < 0 || endIndex >= arr.Length)
            {
                throw new ArgumentOutOfRangeException("Index out of range.");
            }

            int[] slicedArr = new int[endIndex - startIndex + 1];

            for (int i = 0; i < slicedArr.Length; i++)
            {
                slicedArr[i] = arr[startIndex + i -1];
            }

            return slicedArr;
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