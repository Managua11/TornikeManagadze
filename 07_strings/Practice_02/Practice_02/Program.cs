using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a text: ");
        string userInput = Console.ReadLine();

        PrintReversedText(userInput);
    }

    static void PrintReversedText(string text)
    {
        StringBuilder reversedText = new StringBuilder();
        for (int i = text.Length - 1; i >= 0; i--)
        {
            reversedText.Append(text[i]);
        }

        Console.WriteLine("Reversed Text: " + reversedText.ToString());
    }
}