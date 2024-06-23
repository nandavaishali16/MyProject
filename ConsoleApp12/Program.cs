using System;

public class CustomStack
{
    private int[] elements;
    private int top;

    public CustomStack(int capacity)
    {
        elements = new int[capacity];
        top = -1;
    }

    public void Push(int element)
    {
        if (top == elements.Length - 1)
        {
            throw new InvalidOperationException("Stack is full");
        }
        elements[++top] = element;
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty");
        }
        return elements[top--];
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty");
        }
        return elements[top];
    }

    public bool IsEmpty()
    {
        return top == -1;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        CustomStack stack = new CustomStack(5);

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);

        Console.WriteLine("Number of elements in Stack: " + stack.elements.Length);

        while (!stack.IsEmpty())
        {
            Console.Write(stack.Pop() + ",");
        }

        Console.WriteLine("Number of elements in Stack: " + stack.elements.Length);
    }
}