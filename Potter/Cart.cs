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
            var groupedBooks = this.books.GroupBy(book => book.Title).ToDictionary(grouping => grouping.Key, grouping => grouping.Count());

            var bundleCount = groupedBooks.Max(pair => pair.Value);

            return GetTotalPrice(groupedBooks);
        }

        private decimal GetTotalPrice(Dictionary<string, int> remainingBooks)
        {
            var copy = new Dictionary<string, int>(remainingBooks);
            var isSuperDiscount = copy.Count == 5 && copy.Count(b => b.Value >= 2) >= 3;

            var ind = 0;
            foreach (var pair in remainingBooks)
            {
                if ((ind < 4 && isSuperDiscount) || !isSuperDiscount)
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
                ind++;
            }

            var bookCount = isSuperDiscount ? 4 : copy.Count;
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

    public class Combination
    {
        private readonly Dictionary<int, int> bundleOccurences;

        public Combination()
        {
            this.bundleOccurences = new Dictionary<int, int>();
        }

        public void Add(int bookCount)
        {
            if(!this.bundleOccurences.ContainsKey(bookCount))
                this.bundleOccurences.Add(bookCount, 0);

            this.bundleOccurences[bookCount]++;
        }
    }
}