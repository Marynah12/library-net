using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BusinessObjects.Entity;
using Services;
using Services.Services;

namespace LibraryManager.Hosting.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly ICatalogService _catalogService;

        public BookController(ICatalogService catalogService)
        {
            _catalogService = catalogService;
        }

        [HttpGet("books")]
        public IEnumerable<Book> GetAllBooks()
        {
            return _catalogService.ShowCatalog();
        }

        [HttpGet("book/{id}")]
        public Book? GetBookById(int id)
        {
            var book = _catalogService.FindBook(id);
            return book;
        }
  
        [HttpGet("books/fantasy")]
        public IEnumerable<Book> GetBooksByType()
        {
            return _catalogService.GetFantasy();
        }

        [HttpGet("book/topRatedBook")]
        public Book? GetTopRatedBook()
        {
            var topRatedBook = _catalogService.HighestRate();
            return topRatedBook;
        }
    }
}