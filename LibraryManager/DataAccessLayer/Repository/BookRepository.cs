using System;
namespace DataAccessLayer.Repository;
using BusinessObjects.Entity;


public class BookRepository
{
    
    public IEnumerable<Book> GetAll()
    {
        return new List<Book>(); 
    }

    
    public Book Get(int id)
    {
        return new Book(); 
    }
}