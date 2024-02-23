using BusinessObjects.Entity;

namespace BusinessLayer.Catalog
{
    public interface ICatalogManager
    {
        public IEnumerable<Book> DisplayCatalog();
        public IEnumerable<Book> DisplayCatalog(BookType type);
        public Book? FindBook(int id);
        public IEnumerable<Book> GetFantasyBook();
        public Book? HighestRate();
        public void AddBook(Book book);
        public void DeleteBook(int id);

        public void UpdateBook(int id, Book book);
        public void UpdateLibrary(int id, Library library);
        public void UpdateAuthor(int id, Author author);



    }
} 