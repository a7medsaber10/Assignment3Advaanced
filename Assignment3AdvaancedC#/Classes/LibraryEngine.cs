using Assignment3AdvaancedC_.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Assignment3AdvaancedC_.Classes
{
    
    internal class LibraryEngine
    {
        // Use a User-Defined delegate
        public static void ProcessBooks(List<Book> bList, BookDelegate fPtr)
        {
            foreach (Book book in bList)
            {
                Console.WriteLine(fPtr(book));
            }
        }

        // Use a built-in delegate
        public static void ProcessBooksBuilltIn(List<Book> bList, Func<Book, string> fPtr)
        {
            foreach (Book book in bList)
            {
                Console.WriteLine(fPtr(book));
            }
        }
    }
}
