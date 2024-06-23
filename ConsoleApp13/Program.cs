using System;
using System.Collections.Generic;

public class Queue
{
    private List<object> items = new List<object>();

    public void Enqueue(object item)
    {
        items.Add(item);
    }

    public object Dequeue()
    {
        if (items.Count > 0)
        {
            object item = items[0];
            items.RemoveAt(0);
            return item;
        }
        else
        {
            return null;
        }
    }

    public void PrintQueue()
    {
        Console.WriteLine("Current queue elements:");
        foreach (object item in items)
        {
            Console.WriteLine(item);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Queue queue = new Queue();

        // Enqueue elements
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue("B");
        queue.Enqueue(4);
        queue.Enqueue(5);

        // Print current queue elements
        queue.PrintQueue();

        // Dequeue and print the dequeued element
        object dequeuedItem = queue.Dequeue();
        Console.WriteLine($"Dequeued: {dequeuedItem}");

        // Print current queue elements
        queue.PrintQueue();

        // Dequeue and print the dequeued element
        dequeuedItem = queue.Dequeue();
        Console.WriteLine($"Dequeued: {dequeuedItem}");

        // Print current queue elements
        queue.PrintQueue();
        Console.Read();
    }
}