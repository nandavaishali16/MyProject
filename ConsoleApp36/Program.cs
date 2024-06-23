using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create a list of people
        List<Person> people = new List<Person>()
        {
            new Person("Vaishali Nanda", 35),
            new Person("Rajat Yadav", 45),
            new Person("Riya Singh", 40),
            new Person("Kishore Rawat", 30),
            new Person("Sumit Raj", 25)
        };

        // Filter people over 30
        List<Person> peopleOver30 = people.Where(p => p.Age > 30).ToList();

        // Print the names of people over 30
        Console.WriteLine("Persons with age over 30:");
        foreach (Person person in peopleOver30)
        {
            Console.WriteLine(person.Name);
        }

        // Sort the list by age
        people.Sort((p1, p2) => p1.Age.CompareTo(p2.Age));

        // Print the sorted list of people
        Console.WriteLine("\nSorted list of persons:");
        foreach (Person person in people)
        {
            Console.WriteLine($"{person.Name}, Age: {person.Age}");
        }

        // Wait for user input
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
}