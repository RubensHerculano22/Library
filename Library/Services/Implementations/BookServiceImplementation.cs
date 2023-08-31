using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Services.Implementations
{
    public class BookServiceImplementation : IBookService
    {
        private volatile int count;
        public Book Create(Book book)
        {
            return book;
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<Book> FindAll()
        {
            List<Book> people = new List<Book>();
            for (int i = 0; i < 8; i++)
            {
                Book book = MockBook(i);
                people.Add(book);
            }
            return people;
        }

        public Book FindById(long id)
        {
            return new Book
            {
                id = IncrementAndGet(),
                title = "Acotar",
                idGenre = 3,
                year = 2017,
            };
        }

        public Book Update(Book book)
        {
            throw new NotImplementedException();
        }

        private Book MockBook(int i)
        {
            return new Book
            {
                id = IncrementAndGet(),
                title = "Title" + i,
                idGenre = i,
                year = 2000+i,
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
