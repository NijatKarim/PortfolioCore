using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultCatagoryComponentPartial:ViewComponent
    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = context.Categories.ToList();
            return View(values);
        }
    }
}
