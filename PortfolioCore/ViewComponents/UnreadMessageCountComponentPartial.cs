using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class UnreadMessageCountComponentPartial:ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var unreadCount = context.Messages.Count(x => x.MessageIsRead == false);
            return View(unreadCount);
        }
    }
}
