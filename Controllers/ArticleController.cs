namespace LifeGuides.Controllers
{

    using Microsoft.AspNetCore.Mvc;
    using LifeGuides.Models;
    using System.Data.Entity.Core.Common.CommandTrees;
    using Microsoft.AspNetCore.Authorization;

    public class ArticleController : Controller
    {

        ApplicationDBContext dbContext;

        public ArticleController(ApplicationDBContext context)
        {
            dbContext = context;
        }

        public async Task<IActionResult> ArticleView(int id)
        {
            return View(await dbContext.Articles.FindAsync(id));
        }

        [Authorize]
        public IActionResult ArticlePost()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ArticlePost(Article article)
        {
            
            article.authorId = 1;
            article.author = dbContext.Users.Find(1);
            dbContext.Articles.Add(article);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}