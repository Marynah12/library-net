using BusinessObjects.Entity;

namespace BusinessLayer.Catalog
{
    public interface ICatalogManager
    {
        public IEnumerable<Book> DisplayCatalog();
        public IEnumerable<Book> DisplayCatalog(BookType type);

        public Book FindBook(int id);

        public IEnumerable<Book> GetFantasyBook();

        public Book HighestRate();
    }
} 