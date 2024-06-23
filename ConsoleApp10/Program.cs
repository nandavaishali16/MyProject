using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        stack.Push(50);

        Console.WriteLine("Stack in starting:");
        foreach (int element in stack)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Count of elements in stack before popping: " + stack.Count);

        int poppedElement = stack.Pop();
        Console.WriteLine(poppedElement + " element is deleted");

        Console.WriteLine("Stack after popping one element:");
        foreach (int element in stack)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Count of elements in stack after popping: " + stack.Count);

        int peekedElement = stack.Peek();
        Console.WriteLine("Peeked element: " + peekedElement);

        bool isStackEmpty = stack.Count == 0;
        Console.WriteLine("Is stack empty: " + isStackEmpty);

        Console.WriteLine("Press any key to continue . . .");
        Console.ReadKey();
    }
}