using System;
using System.Reflection;

namespace ReflectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load the type (replace "System.String" with the type you want to inspect)
            Type type = typeof(string);

            Console.WriteLine($"Type: {type.Name}");

            // Get all public properties
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine("Public Properties:");
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine($"  {property.Name}");
            }

            // Get all public fields
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine("Public Fields:");
            foreach (FieldInfo field in fields)
            {
                if (field != null)
                {
                    Console.WriteLine($"  {field.Name}");
                }
            }

            // Create an instance of the type
            object instance = string.Empty; // or "Hello, World!"

            // Print out the values of the properties and fields for the instance
            Console.WriteLine("Values for the instance:");
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine($"  {property.Name}: {property.GetValue(instance)}");
            }
            foreach (FieldInfo field in fields)
            {
                if (field != null)
                {
                    Console.WriteLine($"  {field.Name}: {field.GetValue(instance)}");
                }
            }
            Console.Read();
        }
    }
}