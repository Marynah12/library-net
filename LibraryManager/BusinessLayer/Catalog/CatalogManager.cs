using BusinessObjects.Entity;
using DataAccessLayer.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Catalog
{
    public class CatalogManager : ICatalogManager
    {
        private IGenericRepository<Book> _bookRepository;

        public CatalogManager(IGenericRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Book> DisplayCatalog()
        {
            return _bookRepository.GetAll();
        }

        public IEnumerable<Book> DisplayCatalog(BookType type)
        {
            return from book in _bookRepository.GetAll()
                   where book.Type == type
                    select book; 
        }

        public Book FindBook(int id)
        {
            return _bookRepository.Get(id);
        }

        public IEnumerable<Book> GetFantasyBook()
        {
            return _bookRepository.GetAll().Where(book => book.Type == BookType.Fantasy);
        }

        public Book HighestRate()
        {
            List<Book> books = _bookRepository.GetAll().ToList();

            Book book = books.OrderByDescending(book => book.Rate).First();

            return book;
        }

        public void AddBook(Book book)
        {
            _bookRepository.Add(book);
        }

        public void DeleteBook(int id)
        {
            _bookRepository.Delete(id);
        }
        public void UpdateBook(int id, Book book)
        {
            _bookRepository.Update(id, book);
        }

        public void UpdateAuthor(int id, Author author)
        {
            _bookRepository.Update(id, author);
        }

        public void UpdateLibrary(int id, Library library) { 
        
            _bookRepository.Update(id, library);
        }


    }
}
