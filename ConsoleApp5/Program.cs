using System;
class Program
{
    static void Main()
    {
        string[] items = { "Coffee", "Grilled Sandwich", "French Fries", "Noodles", "Pizza" };
        double[] prices = { 50.60, 100.50, 30.0, 80.0, 120.0 };
        int itemIndex = 0;
        int quantity = 0;

        while (true)
        {
            Console.WriteLine("\n1. ShowMenu");
            Console.WriteLine("2. PurchaseItemandQuantity");
            Console.WriteLine("3. CalculateBill");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ShowMenu(items);
                    break;
                case 2:
                    PurchaseItemAndQuantity(items, prices, out itemIndex, out quantity);
                    break;
                case 3:
                    double totalBill = CalculateBill(prices, itemIndex, quantity);
                    Console.WriteLine($"\nTotal Bill: {totalBill}");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ShowMenu(string[] items)
    {
        Console.WriteLine("\nMenu:");
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i]}");
        }
    }

    static void PurchaseItemAndQuantity(string[] items, double[] prices, out int itemIndex, out int quantity)
    {
        Console.Write("\nItemArray= ");
        itemIndex = int.Parse(Console.ReadLine()) - 1;

        Console.Write("PriceOfItem ");
        double price = prices[itemIndex];
        Console.WriteLine(price);

        Console.Write("\nItemPurchased ");
        int itemPurchased = int.Parse(Console.ReadLine());

        Console.Write("ItemQuantityPurchased ");
        quantity = int.Parse(Console.ReadLine());
    }

    static double CalculateBill(double[] prices, int itemIndex, int quantity)
    {
        double price = prices[itemIndex];
        return price * quantity;
    }

}