using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
}

public class Program
{
    public static void Main()
    {
        try
        {
            // Create a list of people
            List<Person> people = new List<Person>()
            {
                new Person("Bob", "Johnson", 35),
                new Person("Vaishali", "Nanda", 42),
                new Person("Eve", "Brown", 31),
                new Person("Frank", "Davis", 37),
                new Person("David", "Jones", 28),
                new Person("Rajat", "Nand", 25),
            };

            // a) Calculate the average age of all persons
            double averageAge = people.Average(p => p.Age);
            Console.WriteLine($"Average age: {averageAge}");

            // b) Find and print the oldest and youngest person's full name
            Person oldestPerson = people.OrderByDescending(p => p.Age).First();
            Person youngestPerson = people.OrderBy(p => p.Age).First();

            Console.WriteLine($"Oldest person: {oldestPerson.FirstName} {oldestPerson.LastName}");
            Console.WriteLine($"Youngest person: {youngestPerson.FirstName} {youngestPerson.LastName}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        Console.ReadLine();
    }
}