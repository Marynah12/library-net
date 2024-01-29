using BusinessLayer.Catalog;
using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CatalogService { 
        private CatalogManager catalogManager = new CatalogManager();

        public void ShowCatalog()
        {
            catalogManager.DisplayCatalog();
        }

        public List<Book> ShowCatalog(BookType type)
        {
            return catalogManager.DisplayCatalog(type);
        }

        public Book FindBook(int id)
        {
            return catalogManager.FindBook(id);
        }

        public List<Book> GetFantasy()
        {
            return catalogManager.GetFantasyBook();
        }

        public Book HighestRate()
        {
            return catalogManager.HighestRate();
        } 

    }
}
