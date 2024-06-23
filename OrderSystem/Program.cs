using System;
using System.Collections.Generic;

public class OrderSystem
{
    public static void Main(string[] args)
    {
        List<string> orderList = new List<string>();
        Dictionary<string, int> itemQuantity = new Dictionary<string, int>();

        while (true)
        {
            Console.WriteLine("Select the item from the menu you want to order:");
            Console.WriteLine("1. Coffee");
            Console.WriteLine("2. Grilled Sandwich");
            Console.WriteLine("3. French Fries");
            Console.WriteLine("4. Noodles");
            Console.WriteLine("5. Pizza");

            int choice = int.Parse(Console.ReadLine());

            string itemName = "";

            switch (choice)
            {
                case 1:
                    itemName = "Coffee";
                    break;
                case 2:
                    itemName = "Grilled Sandwich";
                    break;
                case 3:
                    itemName = "French Fries";
                    break;
                case 4:
                    itemName = "Noodles";
                    break;
                case 5:
                    itemName = "Pizza";
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            Console.WriteLine($"You selected {itemName}");
            Console.WriteLine("Quantity:");

            int quantity = int.Parse(Console.ReadLine());

            if (!itemQuantity.ContainsKey(itemName))
            {
                itemQuantity[itemName] = quantity;
                orderList.Add(itemName);
            }
            else
            {
                itemQuantity[itemName] += quantity;
            }

            Console.WriteLine("You want to add more item: (Y, N)");
            string addMore = Console.ReadLine();

            if (addMore.ToUpper() != "Y")
            {
                break;
            }
        }

        Console.WriteLine("Item selected by you:");

        foreach (string item in orderList)
        {
            Console.Write($"{itemQuantity[item]} {item}, ");
        }

        Console.WriteLine("\nTotal Items:");

        int totalItems = 0;
        foreach (int quantity in itemQuantity.Values)
        {
            totalItems += quantity;
        }

        Console.WriteLine(totalItems);
    }
}
