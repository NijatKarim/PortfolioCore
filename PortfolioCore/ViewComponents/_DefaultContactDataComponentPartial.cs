using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultContactDataComponentPartial:ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values =context.Contacts.ToList();
            return View(values);
        }
    }
}
