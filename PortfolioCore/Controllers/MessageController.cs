using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class MessageController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        [HttpGet]
        public PartialViewResult SendMessage()
        {

            return PartialView();
        }

        [HttpPost]

        public IActionResult SendMessage(Message p)
        {
            p.MessageSendDate = DateTime.Now;
            p.MessageIsRead = false;
            context.Messages.Add(p);
            context.SaveChanges();

            TempData["SuccessMessage"] = "Your message has been sent!";

            return RedirectToAction("Index", "Default");
        }

        public IActionResult Inbox()
        {
            var values = context.Messages.ToList();
            return View(values);
        }

        public IActionResult DeleteMessage(int id)
        {
            var value = context.Messages.Find(id);
            context.Messages.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult ChangeIsReadToTrue(int id)
        {
            var value = context.Messages.Find(id);
            value.MessageIsRead = true;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult ChangeIsReadToFalse(int id)
        {
            var value = context.Messages.Find(id);
            value.MessageIsRead = false;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult MessageDetails(int id)
        {
            var value = context.Messages.Find(id);
            if (!value.MessageIsRead)
            {
                value.MessageIsRead = true;
                context.Update(value);
                context.SaveChanges();
            }
            return View(value);
        }

    }
}
