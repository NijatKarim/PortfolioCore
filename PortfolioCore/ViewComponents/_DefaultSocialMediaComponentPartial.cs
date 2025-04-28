using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultSocialMediaComponentPartial:ViewComponent
    {
        PortfolioContext context =new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values= context.SocialMedia.ToList();
            return View(values);
        }
    }
}
