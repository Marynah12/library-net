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

        public void ShowCatalog(BookType type)
        {
            catalogManager.DisplayCatalog(type);
        }

        public void FindBook(int id)
        {
            catalogManager.FindBook(id);
        }




    }
}
