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

            var discountRate = GetDiscountRate(groupedBooks);
            return 8 * (titleCount * discountRate + (totalBook - titleCount));
        }

        private static decimal GetDiscountRate(Dictionary<string,int> groupedBooks)
        {
            decimal discountRate = 1;

            var permierLot = groupedBooks.Count();
            // reupérer le prix de ce premier lot dans une variable avec le switch
            foreach (var pair in groupedBooks)
            {
                if(pair.Value == 1)
                {
                     groupedBooks.Remove(pair.Key);
                }
                else
                {
                    groupedBooks[pair.Key] = pair.Value - 1;
                }
            }
            var deuxiemeLot = groupedBooks.Count();
            // ajouter le prix de ce deuxieme lot dans la variable avec le switch


            switch (groupedBooks.Count)
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

            }
            
            return discountRate;
        }
    }
}