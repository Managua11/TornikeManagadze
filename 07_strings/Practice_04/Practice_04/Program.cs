namespace Practice_04 {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            int wordCount = CountWords(input);
            PrintWordCount(wordCount);
        }

        static int CountWords(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return 0;
            }
            string[] words = text.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        static void PrintWordCount(int count)
        {
            Console.WriteLine($"The number of words in the string is: {count}");
        }
    }
}