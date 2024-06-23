using System;
using System.Collections.Generic;

public class StackExample
{
    public static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();

        // Push elements onto the stack
        Console.WriteLine("Pushed 10 onto the stack.");
        stack.Push(10);
        Console.WriteLine("Pushed 20 onto the stack.");
        stack.Push(20);
        Console.WriteLine("Pushed 30 onto the stack.");
        stack.Push(30);
        Console.WriteLine("Pushed 40 onto the stack.");
        stack.Push(40);
        Console.WriteLine("Pushed 50 onto the stack.");
        stack.Push(50);

        // Print the current stack
        Console.WriteLine("Current stack: " + string.Join(" ", stack));

        // Peek at the top element
        Console.WriteLine("Peeked: " + stack.Peek());

        // Print the current stack again (unchanged)
        Console.WriteLine("Current stack: " + string.Join(" ", stack));

        // Pop elements from the stack
        Console.WriteLine("Popped 50 from the stack.");
        stack.Pop();
        Console.WriteLine("Current stack: " + string.Join(" ", stack));
        Console.WriteLine("Popped 40 from the stack.");
        stack.Pop();
        Console.WriteLine("Current stack: " + string.Join(" ", stack));
        Console.WriteLine("Popped 30 from the stack.");
        stack.Pop();
        Console.WriteLine("Current stack: " + string.Join(" ", stack));
        Console.WriteLine("Popped 20 from the stack.");
        stack.Pop();
        Console.WriteLine("Current stack: " + string.Join(" ", stack));
        Console.WriteLine("Popped 10 from the stack.");
        stack.Pop();
        Console.WriteLine("Current stack: " + string.Join(" ", stack));
        Console.ReadLine();
    }
}