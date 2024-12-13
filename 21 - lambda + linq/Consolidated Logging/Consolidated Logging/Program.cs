namespace Consolidated_Logging
{
    using System;
    using System.IO;

    class Program
    {
        public delegate void LogMessage(string message);

        static void Main(string[] args)
        {
            LogMessage consoleLogger = LogToConsole;
            LogMessage fileLogger = LogToFile;

            LogMessage consolidatedLogger = consoleLogger + fileLogger;

            string logMessage = "This is a test log message.";
            consolidatedLogger(logMessage);
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
    }
}
