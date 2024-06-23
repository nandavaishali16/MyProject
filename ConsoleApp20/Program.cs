using System;

namespace MyNamespace
{
    public class MyClass
    {
        public static int[] FindNonRepeatingElements(int[] arr)
        {
            int xor = 0;
            int n = arr.Length;

            // Step 1: Find the XOR of all elements
            for (int i = 0; i < n; i++)
            {
                xor ^= arr[i];
            }

            // Step 2: Find the position of the rightmost set bit
            int rightmostSetBit = xor & ~(xor - 1);

            // Step 3: Partition the elements into two groups based on the rightmost set bit
            int x = 0, y = 0;
            for (int i = 0; i < n; i++)
            {
                if ((arr[i] & rightmostSetBit) != 0)
                {
                    x ^= arr[i];
                }
                else
                {
                    y ^= arr[i];
                }
            }

            return new int[] { x, y };
        }

        public static void Main(string[] args)
        {
            int[] arr = { 2, 4, 3, 5, 6, 3, 2 };
            int[] result = FindNonRepeatingElements(arr);
            Console.WriteLine("Non-repeating elements are " + result[0] + " and " + result[1]);
            Console.ReadLine();
        }
    }
}