using System;

public class CustomStack
{
    private const int MaxSize = 10;
    private int[] stack;
    private int top;

    public CustomStack()
    {
        stack = new int[MaxSize];
        top = -1;
    }

    public void Push(int item)
    {
        if (top == MaxSize - 1)
        {
            Console.WriteLine("Stack is full. Cannot push more elements.");
            return;
        }
        stack[++top] = item;
        Console.WriteLine($"Pushed {item} onto the stack.");
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty. Cannot pop any element.");
            return -1;
        }
        int poppedItem = stack[top--];
        Console.WriteLine($"Popped {poppedItem} from the stack.");
        return poppedItem;
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty. Cannot peek any element.");
            return -1;
        }
        return stack[top];
    }

    public bool IsEmpty()
    {
        return top == -1;
    }
}

class Program
{
    static void Main()
    {
        CustomStack stack = new CustomStack();

        Console.WriteLine("Pushing integers onto the stack...");
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);

        Console.WriteLine("Popping and displaying integers from the stack...");
        while (!stack.IsEmpty())
        {
            int poppedItem = stack.Pop();
            Console.WriteLine($"Popped item: {poppedItem}");
        }

        Console.WriteLine("Trying to pop from an empty stack...");
        stack.Pop();

        Console.WriteLine("Trying to peek from an empty stack...");
        stack.Peek();

        Console.WriteLine("Press any key to continue . . .");
        Console.ReadKey();
    }
}