﻿using Microsoft.AspNetCore.Mvc;

namespace SignalRUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
