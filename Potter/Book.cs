using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Potter
{
    public class Book
    {
        public string Title { get; private set; }

        public Book(string title)
        {
            this.Title = title;
        }
    }
}
