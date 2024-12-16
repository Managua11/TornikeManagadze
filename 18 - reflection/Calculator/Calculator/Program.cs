namespace Calculator
{
    using System;
    using System.Reflection;

    class Program
    {
        static void Main()
        {
            Type calculatorType = typeof(Calculator);
            object calculatorInstance = Activator.CreateInstance(calculatorType);

            MethodInfo[] methods = calculatorType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            Console.WriteLine("Available methods:");
            foreach (var method in methods)
            {
                Console.WriteLine($"{method.Name} ({string.Join(", ", method.GetParameters().Select(p => $"{p.ParameterType.Name} {p.Name}"))})");
            }

            Console.WriteLine("\nEnter the name of the method you want to use:");
            string methodName = Console.ReadLine();

            MethodInfo selectedMethod = Array.Find(methods, m => m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase));

            if (selectedMethod == null)
            {
                Console.WriteLine("Invalid method name.");
                return;
            }

            ParameterInfo[] parameters = selectedMethod.GetParameters();
            object[] arguments = new object[parameters.Length];

            try
            {
                for (int i = 0; i < parameters.Length; i++)
                {
                    Console.WriteLine($"Enter value for {parameters[i].Name} ({parameters[i].ParameterType.Name}):");
                    string input = Console.ReadLine();


                    arguments[i] = Convert.ChangeType(input, parameters[i].ParameterType);
                }
                object result = selectedMethod.Invoke(calculatorInstance, arguments);
                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please provide valid numeric values.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }
        }
    }

}
