using Library.Data.Converter.Contract;
using Library.Model;
using System.Collections.Generic;
using System.Linq;

namespace Library.Data.Converter.Implementations
{
    public class BookConverter : IParser<BookVO, Book>, IParser<Book, BookVO> 
    {

        public Book Parse(BookVO origin)
        {
            if (origin == null) return null;

            return new Book
            {
                Id = origin.Id,
                Title = origin.Title,
                Description = origin.Description,
                RegisterDate = origin.RegisterDate,
                AlterDate = origin.AlterDate,
                IdCategory = origin.IdCategory,
                Author = origin.Author,
                PublishDate = origin.PublishDate
            };
        }

        public List<Book> Parse(List<BookVO> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }

        public BookVO Parse(Book origin)
        {
            return new BookVO
            {
                Id = origin.Id,
                Title = origin.Title,
                Description = origin.Description,
                RegisterDate = origin.RegisterDate,
                AlterDate = origin.AlterDate,
                IdCategory = origin.IdCategory,
                Author = origin.Author,
                PublishDate = origin.PublishDate
            };
        }

        public List<BookVO> Parse(List<Book> origin)
        {
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
