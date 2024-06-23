using System;

class Employee
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public decimal BaseSalary { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Gender: {Gender}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Base Salary: ${BaseSalary}");
    }
}

class Manager : Employee
{
    public decimal CalculateBonus()
    {
        return BaseSalary * 0.1m; // 10% bonus for managers
    }

    public new void DisplayDetails()
    {
        base.DisplayDetails();
        decimal bonus = CalculateBonus();
        Console.WriteLine($"Bonus: ${bonus}");
    }
}

class DeliveryPartner : Employee
{
    public decimal CalculateBonus()
    {
        return BaseSalary * 0.2m; // 20% bonus for delivery partners
    }

    public new void DisplayDetails()
    {
        base.DisplayDetails();
        decimal bonus = CalculateBonus();
        Console.WriteLine($"Bonus: ${bonus}");
    }
}

// Example usage
class Program
{
    static void Main(string[] args)
    {
        Manager manager = new Manager
        {
            Name = "Vaishali Nanda",
            Title = "Manager",
            Gender = "Female",
            Age = 25,
            BaseSalary = 5000
        };

        DeliveryPartner deliveryPartner = new DeliveryPartner
        {
            Name = "Rajat",
            Title = "Delivery Partner",
            Gender = "Male",
            Age = 28,
            BaseSalary = 3000
        };

        Employee employee1 = manager;
        employee1.DisplayDetails();

        Console.WriteLine();

        Employee employee2 = deliveryPartner;
        employee2.DisplayDetails();
        Console.ReadLine();
    }
}