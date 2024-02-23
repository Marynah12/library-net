using BusinessLayer.Catalog;
using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CatalogService : ICatalogService
    {
        public CatalogService(ICatalogManager catalogManager )
        {
            _catalogManager = catalogManager; 
        }


        private ICatalogManager _catalogManager; 

        public IEnumerable<Book> ShowCatalog()
        {
            return _catalogManager.DisplayCatalog();
        }

        public IEnumerable<Book> ShowCatalog(BookType type)
        {
            return _catalogManager.DisplayCatalog(type);
        }

        public Book? FindBook(int id)
        {
            return _catalogManager.FindBook(id);
        }

        public IEnumerable<Book> GetFantasy()
        {
            return _catalogManager.GetFantasyBook();
        }

        public Book? HighestRate()
        {
            return _catalogManager.HighestRate();
        }

        public void AddBook(Book book)
        {
            _catalogManager.AddBook(book);
        }


        public void DeleteBook(int id)
        {
            _catalogManager.DeleteBook(id);
        }

        public void UpdateBook(int id, Book book)
        {
            _catalogManager.UpdateBook(id, book);
        }

        public void UpdateAuthor(int id, Author author)
        {
            _catalogManager.UpdateAuthor(id, author);
        }

        public void UpdateLibrary(int id, Library library)
        {
            _catalogManager.UpdateLibrary(id, library);
        }

    }
}


