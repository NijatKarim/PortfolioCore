﻿using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View();
        }
    }
}
