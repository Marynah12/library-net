using System;
using BusinessObjects.Entity;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace BusinessLayer.Catalog
{
	public class CatalogManager
	{
        private BookRepository _bookRepository = new BookRepository();

        public void DisplayCatalog()
            {
                List<Book> books = _bookRepository.GetAll().ToList();
                Console.WriteLine("Voici la liste des livres actuels :");
                foreach (Book book in books)
                {
                    Console.WriteLine(book.Name);
                }
            }

        public List<Book> DisplayCatalog(BookType type)
        {
            List<Book> books = _bookRepository.GetAll().ToList();

            IEnumerable<Book> booksQuery =
                from book in books
                where book.Type == type
                select book;

            //Console.WriteLine($"Voici la liste des livres actuels {books.BookType}");
            foreach (Book book in booksQuery)
            {
                Console.WriteLine(book.Name);
            }
            return books;
        }

        public Book FindBook(int id)
            {
                Book? book = _bookRepository.Get(id);
                Console.WriteLine($"Book with ID {book.Id} {book.Name}");
                return book;
            }
	}
}

