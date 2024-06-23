using System;
using System.Collections.Generic;

public class SimpleStack<T>
{
    private List<T> stack = new List<T>();

    public void Push(T item)
    {
        stack.Add(item);
    }

    public T Pop()
    {
        if (stack.Count == 0)
            throw new InvalidOperationException("Cannot pop from an empty stack.");

        T item = stack[stack.Count - 1];
        stack.RemoveAt(stack.Count - 1);
        return item;
    }

    public T Peek()
    {
        if (stack.Count == 0)
            throw new InvalidOperationException("The stack is empty.");

        return stack[stack.Count - 1];
    }
}

class Program
{
    static void Main(string[] args)
    {
        SimpleStack<int> intStack = new SimpleStack<int>();
        intStack.Push(10);
        intStack.Push(20);
        intStack.Push(30);

        Console.WriteLine("Top element: " + intStack.Peek());
        Console.WriteLine("Popped element: " + intStack.Pop());
        Console.WriteLine("Top element after pop: " + intStack.Peek());

        try
        {
            SimpleStack<string> stringStack = new SimpleStack<string>();
            stringStack.Pop(); // This will throw an InvalidOperationException
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        Console.Read();
    }
}