using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        List<Person> persons = new List<Person>
        {
            new Person { FirstName = "John", LastName = "Doe", Age = 25 },
            new Person { FirstName = "Jane", LastName = "Doe", Age = 35 },
            new Person { FirstName = "Alice", LastName = "Smith", Age = 20 },
            new Person { FirstName = "Bob", LastName = "Johnson", Age = 40 },
            new Person { FirstName = "Eve", LastName = "Smith", Age = 30 },
        };

        // a) Use LINQ to select and print names of all persons whose age is over 30
        var personsOver30 = from person in persons
                            where person.Age > 30
                            select new { person.FirstName, person.LastName };

        Console.WriteLine("Persons over 30:");
        foreach (var person in personsOver30)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName}");
        }

        // b) Order the persons by last name and then by first name and print the sorted list
        var orderedPersons = from person in persons
                             orderby person.LastName, person.FirstName
                             select person;

        Console.WriteLine("\nOrdered persons:");
        foreach (var person in orderedPersons)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName}");
            Console.Read();
        }
    }
}