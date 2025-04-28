using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult ErrorPage(int statusCode)
        {
            if (statusCode == 404)
            {
                return View("Error404"); // 🔥 It loads Views/Error/404.cshtml
            }

            // You can add more error pages later (500, 403, etc.)
            return View("GeneralError"); // fallback view (optional)
        }
    }
}
