using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Exercise2._1
{
    internal class PersonalDigitalLibrary
    {
        public List<Book> Books = new List<Book>();
        public void AddBook(Book book)
        {
            Books.Add(book);
        }
    }
}
