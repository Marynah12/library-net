using System.Collections.Generic;
using System.Linq;
using BusinessObjects.Entity;

namespace DataAccessLayer.Repository
{
    public class AuthorRepository : IGenericRepository<Author>
    {
        private LibraryContext _context;

        public AuthorRepository(LibraryContext context)
        {
            _context = context;
        }

        public IEnumerable<Author> GetAll()
        {
            return _context.Authors.ToList();
        }

        public Author? Get(int id)
        {
            return _context.Authors.Find(id);
        }

        public void Add(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var author = Get(id);
            if (author == null)
            {
                throw new InvalidOperationException($"Author not found.");
            }
            _context.Authors.Remove(author);
            _context.SaveChanges();
        }
    }
}