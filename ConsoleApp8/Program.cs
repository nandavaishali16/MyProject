using System;
using System.Collections.Generic;

public class StackExample
{
    public static void Main(string[] args)
    {
        // Create a stack.
        Stack<int> myStack = new Stack<int>();

        // Push elements onto the stack.
        myStack.Push(10);
        Console.WriteLine("10 is pushed in stack");
        myStack.Push(20);
        Console.WriteLine("20 is pushed in stack");
        myStack.Push(30);
        Console.WriteLine("30 is pushed in stack");
        myStack.Push(40);
        Console.WriteLine("40 is pushed in stack");
        myStack.Push(50);
        Console.WriteLine("50 is pushed in stack");

        // Get the top element of the stack.
        int topElement = myStack.Peek();
        Console.WriteLine("40 is top element");

        // Pop an element off the stack.
        int poppedElement = myStack.Pop();
        Console.WriteLine("50 is popped from stack");

        // Print the stack.
        Console.WriteLine("The stack contains:");
        foreach (int element in myStack)
        {
            Console.WriteLine(element);
        }
        Console.ReadLine();
    }
}