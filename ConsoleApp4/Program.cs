using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Item names and prices
        string[] itemArray = { "Coffee", "Grilled Sandwich", "French Fries", "Noodles", "Pizza" };
        int[] priceArray = { 150, 60, 100, 50, 30 };

        // Initialize variables for purchased items and quantities
        int[] itemPurchased = new int[itemArray.Length];
        int[] itemQuantityPurchased = new int[itemArray.Length];

        // Show the menu
        Console.WriteLine("Menu:");
        for (int i = 0; i < itemArray.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {itemArray[i]} - ${priceArray[i]}");
        }

        // Get user input for purchases
        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Show Menu");
            Console.WriteLine("2. Purchase Item and Quantity");
            Console.WriteLine("3. Calculate Bill");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Show the menu again
                    Console.WriteLine("Menu:");
                    for (int i = 0; i < itemArray.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {itemArray[i]} - ${priceArray[i]}");
                    }
                    break;

                case 2:
                    // Get item and quantity input
                    Console.Write("Enter item number: ");
                    int itemNumber = int.Parse(Console.ReadLine()) - 1;
                    Console.Write("Enter quantity: ");
                    int quantity = int.Parse(Console.ReadLine());

                    // Update purchased items and quantities
                    itemPurchased[itemNumber] = 1; // Mark item as purchased
                    itemQuantityPurchased[itemNumber] += quantity;
                    break;

                case 3:
                    // Calculate and print the bill
                    double totalBill = 0;
                    Console.WriteLine("\nYour Bill:");
                    for (int i = 0; i < itemArray.Length; i++)
                    {
                        if (itemPurchased[i] == 1)
                        {
                            Console.WriteLine($"{itemArray[i]} x {itemQuantityPurchased[i]} - ${priceArray[i] * itemQuantityPurchased[i]}");
                            totalBill += priceArray[i] * itemQuantityPurchased[i];
                        }
                    }
                    Console.WriteLine($"\nTotal Bill: ${totalBill}");
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}