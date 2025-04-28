using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class ContactController : Controller
    {
        PortfolioContext context=new PortfolioContext();
        [HttpGet]
        public IActionResult Index(int id = 1)
        {
            var value = context.Contacts.Find(id);
            return View(value);

        }

        [HttpPost]
        public IActionResult Index(Contact p)
        {
            context.Contacts.Update(p);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
