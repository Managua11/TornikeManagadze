namespace Sequential_Calculations
{
    using System;
    using System.IO;

    internal class Program
    {
        public delegate void LogMessage(string message);

        public delegate decimal MathOperation(decimal a, decimal b);

        static void Main(string[] args)
        {
            LogMessage consoleLogger = LogToConsole;
            LogMessage fileLogger = LogToFile;

            LogMessage consolidatedLogger = consoleLogger + fileLogger;

            string logMessage = "This is a test log message.";
            consolidatedLogger(logMessage);

            MathOperation addition = Add;
            MathOperation subtraction = Subtract;
            MathOperation multiplication = Multiply;
            MathOperation division = Divide;

            MathOperation addAndMultiply = addition + multiplication;
            MathOperation subtractAndDivide = subtraction + division;

            decimal num1 = 10m;
            decimal num2 = 2m;

            Console.WriteLine("Add and Multiply Results:");
            foreach (MathOperation op in addAndMultiply.GetInvocationList())
            {
                Console.WriteLine(op(num1, num2));
            }

            Console.WriteLine("Subtract and Divide Results:");
            foreach (MathOperation op in subtractAndDivide.GetInvocationList())
            {
                Console.WriteLine(op(num1, num2));
            }
        }

        static void LogToConsole(string message)
        {
            Console.WriteLine($"[Console] {message}");
        }

        static void LogToFile(string message)
        {
            string filePath = "log.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"[File] {message}");
            }
        }

        static decimal Add(decimal a, decimal b) => a + b;
        static decimal Subtract(decimal a, decimal b) => a - b;
        static decimal Multiply(decimal a, decimal b) => a * b;
        static decimal Divide(decimal a, decimal b) => b != 0 ? a / b : throw new DivideByZeroException("Cannot divide by zero.");
    }

}
