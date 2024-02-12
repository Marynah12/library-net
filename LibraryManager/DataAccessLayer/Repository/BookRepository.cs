using System.Collections.Generic;
using System.Net;
using BusinessObjects.Entity;

namespace DataAccessLayer.Repository
{
    public class BookRepository : IGenericRepository<Book>
    {
        private LibraryContext _context;
        public BookRepository(LibraryContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetAll()
        {
            return _context.Books.ToList();
        }

        public Book? Get(int id)
        {
            return _context.Books.Find(id);
        }

        public void Add(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var book = Get(id);
            if (book == null)
            {
                throw new InvalidOperationException($"Book not found.");
            }
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }
}