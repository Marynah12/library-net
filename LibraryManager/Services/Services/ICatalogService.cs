using BusinessObjects.Entity;

namespace Services.Services
{
    public interface ICatalogService
    {
        public List<Book> ShowCatalog(BookType type);
        public List<Book> ShowCatalog();

        public Book FindBook(int id);

        public List<Book> GetFantasy();

        public Book HighestRate();
    }
}