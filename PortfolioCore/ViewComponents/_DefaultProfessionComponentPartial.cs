using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultProfessionComponentPartial: ViewComponent
    {
        PortfolioContext context= new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Professions.ToList();
            return View(values);
        }
    }
}
