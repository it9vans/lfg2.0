namespace LifeGuides.Controllers
{
    using System.Data.Entity;
    using LifeGuides.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    public class BookController : Controller
    {
        ApplicationDBContext dbContext;

        public BookController(ApplicationDBContext context)
        {
            dbContext = context;
        }

        public IActionResult Index()
        {
            return View(
                dbContext.Books
                .Join(
                    dbContext.BooksAuthors,
                    book => book.author.id,
                    author => author.id,
                    (_book, _author) => new BookViewModel
                    {
                        bookTitle = _book.title,
                        bookAuthor = _author.name
                    }
                ).ToList()
                );
        }


    }
}