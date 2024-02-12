using BusinessObjects.Entity;

namespace Services.Services
{
    public interface ICatalogService
    {
        public IEnumerable<Book> ShowCatalog(BookType type);
        public IEnumerable<Book> ShowCatalog();
        public Book? FindBook(int id);
        public IEnumerable<Book> GetFantasy();
        public Book? HighestRate();
        public void AddBook(Book book);
        public void DeleteBook(int id);
    }
}