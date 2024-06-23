using System;

namespace InsertElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int elementToInsert = 9;
            int index = 2;

            InsertElement(arr, elementToInsert, index);

            Console.WriteLine("Original array:");
            PrintArray(arr);
        }

        static void InsertElement(int[] arr, int elementToInsert, int index)
        {
            if (index < 0 || index > arr.Length)
            {
                throw new ArgumentOutOfRangeException("Index out of range.");
            }

            Array.Resize(ref arr, arr.Length + 1);

            for (int i = arr.Length - 1; i > index; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[index] = elementToInsert;
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