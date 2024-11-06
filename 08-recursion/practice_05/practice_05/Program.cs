namespace practice_05
{
    internal class Program
    {
        static bool IsPalindrome(string str)
        {
            if (str.Length <= 1)
            {
                return true;
            }

            if (str[0] != str[str.Length - 1])
            {
                return false;  
            }

            return IsPalindrome(str.Substring(1, str.Length - 2));
        }

        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
            }
        }

    }
}
