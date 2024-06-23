using System;
using System.Reflection;

namespace ReflectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load the assembly (you can replace "mscorlib" with any assembly name)
            Assembly assembly = Assembly.Load("mscorlib");

            // Get all types in the assembly
            Type[] types = assembly.GetTypes();

            // Iterate through each type
            foreach (Type type in types)
            {
                Console.WriteLine($"Type: {type.Name}");

                // Get the base type
                Type baseType = type.BaseType;
                if (baseType != null)
                {
                    Console.WriteLine($"  Base Type: {baseType.Name}");
                }
                else
                {
                    Console.WriteLine("  Base Type: None");
                }

                // Get the interfaces implemented by the type
                Type[] interfaces = type.GetInterfaces();
                if (interfaces.Length > 0)
                {
                    Console.WriteLine("  Interfaces:");
                    foreach (Type interfaceType in interfaces)
                    {
                        Console.WriteLine($"    {interfaceType.Name}");
                    }
                }
                else
                {
                    Console.WriteLine("  Interfaces: None");
                }

                Console.WriteLine(); // empty line for readability
                Console.ReadKey();
            }
        }
    }
}