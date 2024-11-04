using System.Text;

namespace Practice_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            int letterCount = CountLetters(input);
            int numberCount = CountNumbers(input);
            int otherCount = CountOthers(input);

            PrintResults(input, letterCount, numberCount, otherCount);
        }

        static int CountLetters(string text)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    count++;
                }
            }
            return count;
        }

        static int CountNumbers(string text)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            return count;
        }

        static int CountOthers(string text)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (!char.IsLetter(c) && !char.IsDigit(c))
                {
                    count++;
                }
            }
            return count;
        }

        static void PrintResults(string originalText, int letters, int numbers, int others)
        {
            Console.WriteLine($"Original text: \"{originalText}\"");
            Console.WriteLine($"Letters: {letters}");
            Console.WriteLine($"Numbers: {numbers}");
            Console.WriteLine($"Others: {others}");
        }
    }
}