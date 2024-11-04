class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter some text:");
        string input = Console.ReadLine();

        PrintCharactersWithSpaces(input);
    }

    static void PrintCharactersWithSpaces(string text)
    {
        foreach (char c in text)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();
    }
}