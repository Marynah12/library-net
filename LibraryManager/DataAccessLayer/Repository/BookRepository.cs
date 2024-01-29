using System.Collections.Generic;
using BusinessObjects.Entity;

namespace DataAccessLayer.Repository
{
    public class BookRepository
    {
        private IEnumerable<Book> _books = new List<Book>
        {
            new Book { Id = 1, Name = "Romance 1", Pages = 100, Type = BookType.Romance, Rate = 5, AuthorId = 1 },
            new Book { Id = 2, Name = "Fantasy 2", Pages = 150, Type = BookType.Fantasy, Rate = 4, AuthorId = 2 }
        };

        public IEnumerable<Book> GetAll()
        {
            return _books;
        }

        public Book? Get(int id)
        {
            return _books.ToList().Find(book => book.Id == id);
        }

       
    }
}