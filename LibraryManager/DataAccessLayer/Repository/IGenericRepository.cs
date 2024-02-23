using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public interface IGenericRepository<T> where T : AEntity

    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Add(T book);
        void Delete(int id);
        void Update(int id, Book book);
        void Update(int id, Author author);
        void Update(int id, Library library);


    }
}

