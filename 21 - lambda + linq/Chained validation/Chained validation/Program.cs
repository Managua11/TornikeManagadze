namespace Chained_validation
{
    internal class Program
    {
        public delegate bool Validator(Book book, out string errorMessage);

        public static void Main(string[] args)
        {

            Book book = new Book
            {
                Title = "C# Programming",
                Author = "John Doe",
                ISBN = "1234567890123",
                Publisher = "Tech Books",
                PublicationDate = DateTime.Now.AddYears(-1),
                Genre = Genre.Technology,
                NumberOfPages = 300,
                IsAvailable = true,
                Price = 29.99m
            };

            Validator titleValidator = ValidateTitle;
            Validator authorValidator = ValidateAuthor;
            Validator isbnValidator = ValidateISBN;
            Validator publisherValidator = ValidatePublisher;
            Validator publicationDateValidator = ValidatePublicationDate;
            Validator genreValidator = ValidateGenre;
            Validator numberOfPagesValidator = ValidateNumberOfPages;
            Validator isAvailableValidator = ValidateIsAvailable;
            Validator priceValidator = ValidatePrice;

            Validator allValidators = titleValidator + authorValidator + isbnValidator +
                                      publisherValidator + publicationDateValidator +
                                      genreValidator + numberOfPagesValidator +
                                      isAvailableValidator + priceValidator;

            List<string> errors = new List<string>();
            foreach (Validator validator in allValidators.GetInvocationList())
            {
                if (!validator(book, out string errorMessage))
                {
                    errors.Add(errorMessage);
                }
            }

            if (errors.Any())
            {
                Console.WriteLine("Validation errors:");
                foreach (string error in errors)
                {
                    Console.WriteLine("- " + error);
                }
            }
            else
            {
                Console.WriteLine("Book is valid!");
            }
        }

        public static bool ValidateTitle(Book book, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(book.Title) || book.Title.Length <= 1 || book.Title.Length >= 255 || !book.Title.All(char.IsLetterOrDigit))
            {
                errorMessage = "Title must be 2-254 characters and contain only letters or digits.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        public static bool ValidateAuthor(Book book, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(book.Author) || book.Author.Length <= 3 || book.Author.Length >= 128 || !book.Author.All(char.IsLetterOrDigit))
            {
                errorMessage = "Author must be 4-127 characters and contain only letters or digits.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        public static bool ValidateISBN(Book book, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(book.ISBN) || book.ISBN.Length != 13 || !book.ISBN.All(char.IsDigit))
            {
                errorMessage = "ISBN must be exactly 13 digits.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        public static bool ValidatePublisher(Book book, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(book.Publisher) || book.Publisher.Length <= 2 || book.Publisher.Length >= 64)
            {
                errorMessage = "Publisher must be 3-63 characters.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        public static bool ValidatePublicationDate(Book book, out string errorMessage)
        {
            if (book.PublicationDate.HasValue && book.PublicationDate.Value >= DateTime.Now)
            {
                errorMessage = "Publication date must be in the past.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        public static bool ValidateGenre(Book book, out string errorMessage)
        {
            if (!Enum.IsDefined(typeof(Genre), book.Genre))
            {
                errorMessage = "Genre is invalid.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        public static bool ValidateNumberOfPages(Book book, out string errorMessage)
        {
            if (book.NumberOfPages <= 0)
            {
                errorMessage = "Number of pages must be greater than 0.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        public static bool ValidateIsAvailable(Book book, out string errorMessage)
        {
            if (!book.IsAvailable)
            {
                errorMessage = "Availability must be true.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        public static bool ValidatePrice(Book book, out string errorMessage)
        {
            if (book.Price.HasValue && book.Price.Value <= 0)
            {
                errorMessage = "Price must be greater than 0 if specified.";
                return false;
            }
            errorMessage = null;
            return true;
        }
    }



}
