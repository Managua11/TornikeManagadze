namespace Custom_Data_Pipelines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example list of books
            List<Book> books = new List<Book>
        {
            new Book { Title = "C# Programming", Author = "John Doe", ISBN = "1234567890123", Publisher = "Tech Books", PublicationDate = DateTime.Now.AddYears(-1), Genre = Genre.Technology, NumberOfPages = 300, IsAvailable = true, Price = 29.99m },
            new Book { Title = "Fiction Book", Author = "Jane Smith", ISBN = "9876543210123", Publisher = "Fiction House", PublicationDate = DateTime.Now.AddYears(-5), Genre = Genre.Fiction, NumberOfPages = 200, IsAvailable = false, Price = 15.99m },
            new Book { Title = "History 101", Author = "Alex Brown", ISBN = "5556667778881", Publisher = "History Press", PublicationDate = DateTime.Now.AddYears(-10), Genre = Genre.History, NumberOfPages = 500, IsAvailable = true, Price = 25.00m }
        };

            // Filters and transformers setup
            var pipeline = new DataPipeline<Book, BookDto>();
            pipeline.AddFilter(book => book.PublicationDate.HasValue && book.PublicationDate.Value.Year > 2000);
            pipeline.AddFilter(book => book.NumberOfPages < 300);
            pipeline.AddTransformer(book => new BookDto
            {
                Title = book.Title,
                Author = book.Author,
                Genre = book.Genre,
                IsAvailable = book.IsAvailable,
                Price = book.Price
            });

            // Process the books through the pipeline
            var result = pipeline.Process(books);

            // Output the results
            Console.WriteLine("Filtered and Transformed Books:");
            foreach (var bookDto in result)
            {
                Console.WriteLine($"Title: {bookDto.Title}, Author: {bookDto.Author}, Genre: {bookDto.Genre}, IsAvailable: {bookDto.IsAvailable}, Price: {bookDto.Price:C}");
            }
        }
    }

}
