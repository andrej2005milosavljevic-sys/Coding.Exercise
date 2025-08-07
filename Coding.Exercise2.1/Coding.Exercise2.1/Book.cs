using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Exercise2._1
{
    internal class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string ISBN { get; }

        public Book(string title, string author, string isbn)
        {
            if(string.IsNullOrWhiteSpace(title)) throw new ArgumentNullException("Title cannot be null or empty");
            if (string.IsNullOrWhiteSpace(author)) throw new ArgumentNullException("Author cannont be null or empty");
            if (string.IsNullOrWhiteSpace(isbn)) throw new ArgumentNullException("ISBN cannot be null or empty");


            Title = title;
            Author = author;
            ISBN = isbn;
        }
    }
}
