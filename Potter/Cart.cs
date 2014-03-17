using System.Collections.Generic;

using System.Linq;

namespace Potter
{
    public class Cart
    {
        private readonly List<Book> books;

        public Cart()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public decimal GetPrice()
        {
            var titleCount = this.books.Select(b => b.Title).Distinct().Count();
            var totalBook = books.Count();
            if (titleCount == 2)
            {
                return this.GetPriceForTwoDisitnctBooks() + (8*(totalBook-2));
            }
            
            return 8 * books.Count;
        }

        private decimal GetPriceForTwoDisitnctBooks()
        {
            return 8 * 2 * 0.95m;
        }
    }
}