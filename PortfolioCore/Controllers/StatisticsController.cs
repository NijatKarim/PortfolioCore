using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.Controllers
{
    public class StatisticsController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v0 = "Statistika";
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Skills.Sum(x=>x.SkillValue);
            ViewBag.v3 = context.Skills.Where(x => x.SkillValue > 70).Count();
            ViewBag.v4 = context.Skills.Average(x => x.SkillValue);
            ViewBag.v5= context.Experiences.Count();    
            ViewBag.v6= context.Experiences.Where(x=>x.ExperienceSubTitle.Contains("Developer")).Count();
            ViewBag.v7=context.Messages.Where(x=>x.MessageIsRead==true).Count();
            ViewBag.v8=context.Messages.Where(x=>x.MessageIsRead==false).Count();
            ViewBag.v9=context.Messages.Count();
            ViewBag.v10=context.Educations.Count();
            ViewBag.v11=context.Portfolios.Count();

            return View();
        }
    }
}
