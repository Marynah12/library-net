using System.Collections.Generic;
using BusinessObjects.Entity;

namespace DataAccessLayer.Repository
{
    public class LibraryRepository : IGenericRepository<Library>
    {

        private LibraryContext _context;

        public LibraryRepository(LibraryContext context)
        {
            _context = context;
        }

        public IEnumerable<Library> GetAll()
        {

            return _context.Libraries.ToList();
        }


        public Library? Get(int id)
        {

            return _context.Libraries.Find(id);
        }

        public void Add(Library library)
        {
            _context.Libraries.Add(library);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var library = Get(id);
            if (library == null)
            {
                throw new InvalidOperationException($"Library not found.");
            }
            _context.Libraries.Remove(library);
            _context.SaveChanges();
        }
    }
}
