using System.Collections.Generic;
using BusinessLayer.Catalog;
using BusinessObjects.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Services.Services;

namespace Services.Test
{
    [TestClass]
    public class CatalogServiceTest
    {
        [TestMethod]
        public void GetAllBooks_Returns_Books()
        {
            var mockCatalogManager = new Mock<ICatalogManager>();
            mockCatalogManager.Setup(manager => manager.DisplayCatalog()).Returns(new List<Book>());

            var catalogService = new CatalogService(mockCatalogManager.Object);

            var result = catalogService.ShowCatalog();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetBookById_Returns_Book()
        {
            int bookId = 1;
            var mockCatalogManager = new Mock<ICatalogManager>();
            mockCatalogManager.Setup(manager => manager.FindBook(bookId)).Returns(new Book { Id = bookId });

            var catalogService = new CatalogService(mockCatalogManager.Object);

            var result = catalogService.FindBook(bookId);

            Assert.IsNotNull(result);
            Assert.AreEqual(bookId, result.Id);
        }

        [TestMethod]
        public void GetFantasy_Returns_FantasyBooks()
        {
            var expectedBooks = new List<Book>
            {
                new Book { Id = 1, Name = "F1", Type = BookType.Fantasy, Pages = 22, AuthorId = 1, Rate = 3  },
                new Book { Id = 2, Name = "F2", Type = BookType.Fantasy, Pages = 55, AuthorId = 1, Rate = 4  },
                new Book { Id = 3, Name = "F3", Type = BookType.Fantasy, Pages = 211, AuthorId = 2, Rate = 1  }
            };

            var mockCatalogManager = new Mock<ICatalogManager>();
            mockCatalogManager.Setup(manager => manager.GetFantasyBook()).Returns(expectedBooks);

            var catalogService = new CatalogService(mockCatalogManager.Object);

            var result = catalogService.GetFantasy();

            CollectionAssert.AreEqual(expectedBooks, result.ToList());
        }

        [TestMethod]
        public void HighestRate_Returns_HighestRatedBook()
        {
            var highestRatedBook = new Book { Id = 1, Name = "F4", Type = BookType.Fantasy, Pages = 223, AuthorId = 1, Rate = 3 };

            var mockCatalogManager = new Mock<ICatalogManager>();
            mockCatalogManager.Setup(manager => manager.HighestRate()).Returns(highestRatedBook);

            var catalogService = new CatalogService(mockCatalogManager.Object);

            var result = catalogService.HighestRate();

            Assert.AreEqual(highestRatedBook, result);
        }


    }
}