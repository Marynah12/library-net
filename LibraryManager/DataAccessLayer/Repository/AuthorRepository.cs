using System.Collections.Generic;
using BusinessObjects.Entity;

namespace DataAccessLayer.Repository
{
    public class AuthorRepository : IGenericRepository<Author>
    {
        private List<Author> _authors = new List<Author>
        {
            new Author { Id = 1, FirstName = "Pierre", LastName = "Dupont"  },
            new Author { Id = 2, FirstName = "Jack", LastName = "Portel"  }

        };

        public IEnumerable<Author> GetAll()
        {
            return _authors;
        }

        public Author? Get(int id)
        {
            return _authors.Find(author => author.Id == id);
        }
    }
}
