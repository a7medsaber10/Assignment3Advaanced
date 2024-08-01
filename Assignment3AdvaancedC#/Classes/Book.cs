using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3AdvaancedC_.Classes
{
    internal class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublictionDate { get; set; }
        public decimal Price { get; set; }

        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublictionDate, decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublictionDate = _PublictionDate;
            Price = _Price;            
        }

        public override string ToString()
        {
            return $"ISBN: {ISBN}, Title: {Title}, Price: {Price}";
        }

    }
}


