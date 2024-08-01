using Assignment3AdvaancedC_.Classes;



namespace Assignment3AdvaancedC_
{
    #region Part01 Delegate
    internal delegate string BookDelegate(Book book); 
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            //List<Book> books = new List<Book>
            //{
            //    new Book("1234567", "Book1", new string[] {"Author1"}, DateTime.Now, 22.5m),
            //    new Book("9874561", "Book2", new string[] {"Author2"}, DateTime.Now, 30.7m)
            //};

            //// using user-defined delegate
            //BookDelegate TitleDelegate = BookFunctions.GetTitle;
            //LibraryEngine.ProcessBooks(books, TitleDelegate);

            //// using built-in delegate
            //Func<Book, string> priceFunc = BookFunctions.GetPrice;
            //LibraryEngine.ProcessBooksBuilltIn(books, priceFunc);

            //// Anonymos method
            //LibraryEngine.ProcessBooks(books, delegate (Book b) { return b.ISBN; });

            //// lambda expression
            //LibraryEngine.ProcessBooks(books, b => b.PublictionDate.ToString("d")); 
            #endregion

            #region Part02
            //MyList<int> myList = new MyList<int>();

            //myList.Add(1);
            //myList.Add(2);
            //myList.Add(3);
            //myList.Add(4);
            //myList.Add(5);

            //Console.WriteLine("Exists (greater than 3): " + myList.Exists(delegate (int x) { return x > 3; }));
            //Console.WriteLine("Find (greater than 3): " + myList.Find(delegate (int x) { return x > 3; }));
            //Console.WriteLine("FindAll (greater than 3): " + string.Join(", ", myList.FindAll(delegate (int x) { return x > 3; })));
            //Console.WriteLine("FindIndex (greater than 3): " + myList.FindIndex(delegate (int x) { return x > 3; }));
            //Console.WriteLine("FindLast (greater than 3): " + myList.FindLast(delegate (int x) { return x > 3; }));
            //Console.WriteLine("FindLastIndex (greater than 3): " + myList.FindLastIndex(delegate (int x) { return x > 3; }));

            //myList.ForEach(delegate (int x) { Console.WriteLine("ForEach item: " + x); });

            //Console.WriteLine("TrueForAll (greater than 0): " + myList.TrueForAll(delegate (int x) { return x > 0; }));
            //Console.WriteLine("TrueForAll (greater than 3): " + myList.TrueForAll(delegate (int x) { return x > 3; })); 
            #endregion
        }
    }
}
