namespace practice_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your day of birth: ");
            string dayInput = Console.ReadLine();

            Console.Write("Enter your month of birth: ");
            string monthInput = Console.ReadLine().ToLower(); 

            if (int.TryParse(dayInput, out int day))
            {
                string zodiac = GetZodiacSign(day, monthInput);
                Console.WriteLine($"{dayInput} {monthInput}  is {zodiac}.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid day.");
            }
        }

        static string GetZodiacSign(int day, string month)
        {
            switch (month)
            {
                case "january":
                    return (day <= 19) ? "Capricorn" : "Aquarius";
                case "february":
                    return (day <= 18) ? "Aquarius" : "Pisces";
                case "march":
                    return (day <= 20) ? "Pisces" : "Aries";
                case "april":
                    return (day <= 19) ? "Aries" : "Taurus";
                case "may":
                    return (day <= 20) ? "Taurus" : "Gemini";
                case "june":
                    return (day <= 20) ? "Gemini" : "Cancer";
                case "july":
                    return (day <= 22) ? "Cancer" : "Leo";
                case "august":
                    return (day <= 22) ? "Leo" : "Virgo";
                case "september":
                    return (day <= 22) ? "Virgo" : "Libra";
                case "october":
                    return (day <= 22) ? "Libra" : "Scorpio";
                case "november":
                    return (day <= 21) ? "Scorpio" : "Sagittarius";
                case "december":
                    return (day <= 21) ? "Sagittarius" : "Capricorn";
                default:
                    return "Unknown month. Please enter a valid month name.";
            }
        }
    }
}
