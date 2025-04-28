using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultStatsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Random rnd = new Random();

            ViewBag.MyReferencesCount=rnd.Next(10, 20);
            ViewBag.ProjectsCount=rnd.Next(10, 20);
            ViewBag.SkillsCount=rnd.Next(10, 20);
            return View();
        }
    }
}
