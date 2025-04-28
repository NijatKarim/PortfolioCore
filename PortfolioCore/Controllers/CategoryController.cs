using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class CategoryController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult Index()
        {
            var values=context.Categories.ToList();
            return View(values);
        }

        [HttpGet]

        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category p)
        {
            context.Categories.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }




        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var value = context.Categories.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category p)
        {
            context.Categories.Update(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
