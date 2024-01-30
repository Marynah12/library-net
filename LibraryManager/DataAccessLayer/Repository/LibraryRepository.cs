using System.Collections.Generic;
using BusinessObjects.Entity;

namespace DataAccessLayer.Repository
{
    public class LibraryRepository
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
    }
}
