using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LifeGuides.Models;
using System.Data.Entity;

namespace LifeGuides.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    ApplicationDBContext dbContext;

    public HomeController(ILogger<HomeController> logger, ApplicationDBContext context)
    {
        _logger = logger;
        dbContext = context;
    }

    public IActionResult Index()
    {
        //return View(dbContext.Articles.Include(a=>a.author).ToList());
        return View(
            dbContext.Articles
            .Join(
                dbContext.Users,
                article => article.author.id,
                user => user.id,
                (_article, _user) => new ArticleViewModel
                {
                    articleId = _article.id,
                    articleTitle = _article.title,
                    articleDescription = _article.description,
                    articleAuthor = _user.nickname
                }


            ).ToList()
        );
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
