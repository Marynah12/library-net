using System.Collections.Generic;
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

        
       
    }
}