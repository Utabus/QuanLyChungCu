﻿using Microsoft.AspNetCore.Mvc;

namespace WebQuanLyChungCu.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RequestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
