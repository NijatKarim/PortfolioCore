﻿using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultServicesComponentPartial:ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Services
                .OrderByDescending(x=>x.ServiceId)
                .Take(6)
                .ToList();
            return View(values);
        }
    }
}
