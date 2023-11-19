namespace LifeGuides.Controllers
{
    using System.Data.Entity;
    using LifeGuides.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    public class TableTestController : Controller
    {
        ApplicationDBContext dbContext;

        public TableTestController(ApplicationDBContext context)
        {
            dbContext = context;
        }

        [Authorize(Roles = "Admin")]
        [IgnoreAntiforgeryToken]
        public IActionResult Index()
        {
            return View(dbContext.TableTests.ToList());
        }


    }
}