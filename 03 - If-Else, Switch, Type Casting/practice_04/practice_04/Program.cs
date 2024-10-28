namespace practice_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your year of birth: ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int year))
            {
                string zodiac = GetChineseZodiac(year);
                Console.WriteLine($" {year} was {zodiac} year");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid year.");
            }
        }

        static string GetChineseZodiac(int year)
        {
            int remainder = (year - 1900) % 12;

            if (year < 1900)
            {
                remainder = (remainder + 12) % 12;
            }

            switch (remainder)
            {
                case 0:
                    return "Rat";
                case 1:
                    return "Ox";
                case 2:
                    return "Tiger";
                case 3:
                    return "Rabbit";
                case 4:
                    return "Dragon";
                case 5:
                    return "Snake";
                case 6:
                    return "Horse";
                case 7:
                    return "Goat";
                case 8:
                    return "Monkey";
                case 9:
                    return "Rooster";
                case 10:
                    return "Dog";
                case 11:
                    return "Pig";
                default:
                    return "Unknown";
                }
            }
    }
}
