using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class AboutController : Controller
    {
        PortfolioContext context= new PortfolioContext();
        [HttpGet]
        public IActionResult Index(int id=1)
        {
            var value = context.Abouts.Find(id);
            return View(value);
            
        }

        [HttpPost]
        public IActionResult Index(About p)
        {
            context.Abouts.Update(p);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
