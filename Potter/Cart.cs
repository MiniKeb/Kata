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
            var groupedBooks = this.books.GroupBy(book => book.Title).ToDictionary(grouping => grouping.Key, grouping => grouping.Count());
            var totalBook = books.Count();

            //var discountRate = GetDiscountRate(groupedBooks.Count);
            //return 8 * (titleCount * discountRate + (totalBook - titleCount));
            return GetTotalPrice(groupedBooks);
        }

        private decimal GetTotalPrice(Dictionary<string, int> remainingBooks)
        {
            var copy = new Dictionary<string, int>(remainingBooks);
            foreach (var pair in remainingBooks)
            {
                if (pair.Value == 0)
                {
                    copy.Remove(pair.Key);
                }
                else
                {
                    copy[pair.Key] = pair.Value - 1;
                }
            }

            var bookCount = copy.Count();
            var currentPrice = 8 * GetDiscountRate(bookCount) * bookCount;

            decimal nextPrice = 0;
            if(copy.Count > 0)
                nextPrice = this.GetTotalPrice(copy);
            
            return currentPrice + nextPrice;
        }


        private static decimal GetDiscountRate(int count)
        {
            decimal discountRate;
            switch (count)
            {
                case 2:
                    discountRate = 0.95m;
                    break;
                case 3:
                    discountRate = 0.90m;
                    break;
                case 4:
                    discountRate = 0.80m;
                    break;
                case 5:
                    discountRate = 0.75m;
                    break;
                default:
                    discountRate = 1m;
                    break;
            }
            return discountRate;
        }
    }
}