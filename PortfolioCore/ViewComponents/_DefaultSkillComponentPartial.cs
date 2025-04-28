using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultSkillComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            PortfolioContext context = new PortfolioContext();
            var values=context.Skills.ToList();
            return View(values);
        }
    }
}
