using Assignment3AdvaancedC_.Classes;



namespace Assignment3AdvaancedC_
{
    internal delegate string BookDelegate(Book book);
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book("1234567", "Book1", new string[] {"Author1"}, DateTime.Now, 22.5m),
                new Book("9874561", "Book2", new string[] {"Author2"}, DateTime.Now, 30.7m)
            };

            // using user-defined delegate
            BookDelegate TitleDelegate = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks(books, TitleDelegate);

            // using built-in delegate
            Func<Book, string> priceFunc = BookFunctions.GetPrice;
            LibraryEngine.ProcessBooksBuilltIn(books, priceFunc);

            // Anonymos method
            LibraryEngine.ProcessBooks(books, delegate (Book b) { return b.ISBN; });

            // lambda expression
            LibraryEngine.ProcessBooks(books, b => b.PublictionDate.ToString("d"));
        }
    }
}
