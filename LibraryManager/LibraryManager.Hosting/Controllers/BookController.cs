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
        private readonly CatalogService _catalogService;

        public BookController(CatalogService catalogService)
        {
            _catalogService = catalogService;
        }

        [HttpGet("books")]
        public IEnumerable<Book> GetAllBooks()
        {
            return _catalogService.ShowCatalog();
        }

        [HttpGet("book/{id}")]
        public ActionResult<Book> GetBookById(int id)
        {
            var book = _catalogService.FindBook(id);
            if (book == null)
            {
                return NotFound();
            }
            return book;
        }
        // A faire
        //[HttpGet("books/{type}")]
        //public IEnumerable<Book> GetBooksByType(string type)
        //{
        //    return _catalogService.GetFantasy(type);
        //}

        [HttpGet("book/topRatedBook")]
        public ActionResult<Book> GetTopRatedBook()
        {
            var topRatedBook = _catalogService.HighestRate();
            if (topRatedBook == null)
            {
                return NotFound();
            }
            return topRatedBook;
        }
    }
}