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

        public List<Book> ShowCatalog()
        {
            return _catalogManager.DisplayCatalog();
        }

        public List<Book> ShowCatalog(BookType type)
        {
            return _catalogManager.DisplayCatalog(type);
        }

        public Book FindBook(int id)
        {
            return _catalogManager.FindBook(id);
        }

        public List<Book> GetFantasy()
        {
            return _catalogManager.GetFantasyBook();
        }

        public Book HighestRate()
        {
            return _catalogManager.HighestRate();
        } 

    }
}


