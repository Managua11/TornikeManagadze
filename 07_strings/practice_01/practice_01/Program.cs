class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a text: ");
        string userInput = Console.ReadLine();

        PrintVowels(userInput);
        PrintConsonants(userInput);
    }

    static void PrintVowels(string text)
    {
        string vowels = "aeiouAEIOU";
        string foundVowels = "";
        int count = 0; 
        foreach (char c in text)
        {
            if (vowels.Contains(c))
            {
                count++;
                foundVowels += c + " ";
            }
        }
        Console.WriteLine("Vowel count " +count );
        Console.WriteLine("Vowels: " + foundVowels.Trim());
    }

    static void PrintConsonants(string text)
    {
        string consonants = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";
        string foundConsonants = "";
        int count = 0;
        foreach (char c in text)
        {
            if (consonants.Contains(c))
            {
                count++;
                foundConsonants += c + " ";
            }
        }
        Console.WriteLine("Consonant count " +count);
        Console.WriteLine("Consonants: " + foundConsonants.Trim());
    }
}
