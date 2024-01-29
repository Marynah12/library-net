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
        private CatalogManager _catalogManager = new CatalogManager();

        public void ShowCatalog()
        {
            _catalogManager.DisplayCatalog();
        }

        public void ShowCatalog(BookType type)
        {
            _catalogManager.DisplayCatalog(type);
        }


        public Book FindBook(int id)
        {
            return _catalogManager.FindBook(id);
        }

        
    }
}
