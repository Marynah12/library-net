using System.Collections.Generic;
using BusinessObjects.Entity;

namespace DataAccessLayer.Repository
{
    public class LibraryRepository
    {
   
        public IEnumerable<Library> GetAll()
        {
           
            return new List<Library>(); 
        }


        public Library Get(int id)
        {
          
            return new Library(); 
        }
    }
}
