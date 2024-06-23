using System;
using System.Reflection;

namespace MyClass
{
    public class MyClass
    {
        public void Vaishali(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public void PrintDate()
        {
            Console.WriteLine($"Today's date is: {DateTime.Now.ToShortDateString()}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an instance of MyClass
            MyClass myClassInstance = new MyClass();

            // Ask the user for the method name
            Console.WriteLine("Enter method name to invoke:");
            string methodName = Console.ReadLine();

            // Get the method information using reflection
            MethodInfo methodInfo = typeof(MyClass).GetMethod(methodName);

            if (methodInfo == null)
            {
                Console.WriteLine("Method not found.");
                return;
            }

            // Get the parameters of the method
            ParameterInfo[] parameters = methodInfo.GetParameters();
            object[] parameterValues = new object[parameters.Length];

            // Ask the user for the values of the parameters if any
            for (int i = 0; i < parameters.Length; i++)
            {
                Console.WriteLine($"Enter parameter (if any) for '{parameters[i].Name}' of type '{parameters[i].ParameterType}':");
                string input = Console.ReadLine();
                try
                {
                    parameterValues[i] = Convert.ChangeType(input, parameters[i].ParameterType);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error converting parameter: {ex.Message}");
                    return;
                }
            }

            // Invoke the method and handle any exceptions
            try
            {
                object result = methodInfo.Invoke(myClassInstance, parameterValues);
                if (methodInfo.ReturnType != typeof(void))
                {
                    Console.WriteLine($"Method returned: {result}");
                }
            }
            catch (TargetInvocationException tie)
            {
                Console.WriteLine($"An error occurred while invoking the method: {tie.InnerException?.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}