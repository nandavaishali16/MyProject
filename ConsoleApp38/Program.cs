using System;

class Book
{
    public string Author { get; set; }
    public string Title { get; set; }
    public double AveragePrice { get; set; }

    public void DisplayBookDetails()
    {
        Console.WriteLine($"Book written by {Author}: {Title}");
        Console.WriteLine($"Average price: {AveragePrice}");
        Console.WriteLine("Press any key to continue . . .");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book
        {
            Author = "Victory City ",
            Title = "Salman Rushdie",
            AveragePrice = 150.555556
        };

        book.DisplayBookDetails();
        Console.ReadKey();
    }
}