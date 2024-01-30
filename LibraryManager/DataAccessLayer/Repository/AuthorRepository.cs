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
    }
}